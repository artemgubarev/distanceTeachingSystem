using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YandexDisk.Client.Clients;
using YandexDisk.Client.Http;
using YandexDisk.Client.Protocol;

namespace DistanceTeachingSystem
{
    class YandexDisk
    {
        const string token = "AQAAAABb39FLAAeXvhANBxjOrEkOrH8U7giSBSs";
        const string folderName = "DistanceTeaching";
        
        // загрузить файлы на диск
        public async Task UploadFiles(OpenFileDialog dialog, string disciplineTitle, string pathName, ListView listView)
        {
            try
            {
                var api = new DiskHttpApi(token);

                var rootFolderData = await api.MetaInfo.GetInfoAsync(new ResourceRequest
                {
                    Path = "/"
                });


                var files = dialog.FileNames;

                // каждый выбранный файл загружаем на диск
                foreach (var file in files)
                {
                    var link = await api.Files.GetUploadLinkAsync("/" + folderName + "/" + disciplineTitle + "/" +
                                      pathName + "/" + Path.GetFileName(file), overwrite: false);

                    using (var fs = File.OpenRead(file))
                    {
                        await api.Files.UploadAsync(link, fs);
                        listView.Items.Add(new ListViewItem(new string[] { Path.GetFileName(file) }));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // удалить файлы с диска
        public async Task DeleteFiles(string disciplineTitle, string pathName, ListView listView)
        {
            try
            {
                var api = new DiskHttpApi(token);

                var rootFolderData = await api.MetaInfo.GetInfoAsync(new ResourceRequest
                {
                    Path = "/" + folderName + "/" + disciplineTitle + "/" + pathName + "/"
                });

                foreach (var item in rootFolderData.Embedded.Items)
                {
                    foreach (ListViewItem ListViewitem in listView.SelectedItems)
                    {
                        if (item.Name == ListViewitem.SubItems[0].Text)
                        {
                            DeleteFileRequest d = new DeleteFileRequest();
                            d.Path = item.Path;
                            d.Permanently = false;

                            await api.Commands.DeleteAsync(d);

                            listView.Items.Remove(ListViewitem);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //отобразить файлы в ListView
        public async Task ShowFiles(string disciplineTitle, string pathName, ListView listView, User user, DistanceTeaching distanceTeaching)
        {
            var api = new DiskHttpApi(token);

            var rootFolderData = await api.MetaInfo.GetInfoAsync(new ResourceRequest
            {
                Path = "/" + folderName + "/" + disciplineTitle + "/" + pathName
            });

            switch(listView.Name)          
            {
                case "listViewExercises":
                // отображение файлов для студента
                if (user.GetType() == typeof(Student))
                {
                    Student student = (Student)user;


                    foreach (var item in rootFolderData.Embedded.Items)
                    {
                        Exercise exercise = student.Exercises.Find(ex => ex.Title == item.Name);

                        // если существует такое задание добовляем в ListView
                        if (exercise != null)
                        {
                            ListViewItem listViewItem = new ListViewItem(new string[] { item.Name, item.Created.ToString(),
                        student.Name,  exercise.Grade.ToString() });

                            listViewItem.Tag = exercise;

                            listView.Items.Add(listViewItem);
                        }

                    }

                }

                // отображение файлов для преподавателя
                if (user.GetType() == typeof(Teacher))
                {
                    Teacher teacher = (Teacher)user;

                    foreach (User userData in distanceTeaching.Users)
                    {
                        if (userData.GetType() == typeof(Student))
                        {
                            Student student = (Student)userData;

                            foreach (var item in rootFolderData.Embedded.Items)
                            {
                                Exercise exercise = student.Exercises.Find(ex => ex.Title == item.Name);

                                // если существует такое задание добовляем в ListView
                                if (exercise != null)
                                {
                                    ListViewItem listViewItem = new ListViewItem(new string[] { item.Name, item.Created.ToString(),
                                                             student.Name,  exercise.Grade.ToString() });

                                    listViewItem.Tag = exercise;

                                    listView.Items.Add(listViewItem);
                                }
                            }
                        }
                    }
                }
                    break;

                case "listViewMaterials":
                    foreach (var item in rootFolderData.Embedded.Items)
                    {
                        ListViewItem listViewItem = new ListViewItem(new string[] { item.Name, item.Created.ToString(),
                                                             (item.Size/1024).ToString()+" кб" });

                        listView.Items.Add(listViewItem);
                    }
                    break;
            }


          

        }

        // загрузка файлов
        public async Task DownloadFiles(string path, string pathName, string disciplineTitle, ListView listView)
        {
            try
            {
                var api = new DiskHttpApi(token);

                var rootFolderData = await api.MetaInfo.GetInfoAsync(new ResourceRequest
                {
                    Path = "/" + folderName + "/" + disciplineTitle + "/" + pathName
                });

                foreach (var item in rootFolderData.Embedded.Items)
                {
                    foreach (ListViewItem i in listView.SelectedItems)
                    {
                        if (item.Name == i.SubItems[0].Text)
                        {
                            await api.Files.DownloadFileAsync(path: item.Path, Path.Combine(path, item.Name));
                        }

                    }
                }
                MessageBox.Show("Файлы загружены в " + path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // создание директории
        public async Task CreateDirectory(string disciplineTitle)
        {
            var api = new DiskHttpApi(token);

            var rootFolderData = await api.MetaInfo.GetInfoAsync(new ResourceRequest
            {
                Path = "/"
            });

            // если нет директории с именем folderName
            if (!rootFolderData.Embedded.Items.Any(i => i.Type == ResourceType.Dir && i.Name.Equals(disciplineTitle)))
            {
                // создание директории
                await api.Commands.CreateDictionaryAsync("/" + folderName + "/" + disciplineTitle);
                await api.Commands.CreateDictionaryAsync("/" + folderName + "/" + disciplineTitle + "/" + "Materials");
                await api.Commands.CreateDictionaryAsync("/" + folderName + "/" + disciplineTitle + "/" + "Exercises");
            }
        }

        // удалить директорию
        public async void DeleteDirectory(string disciplineTitle)
        {
            var api = new DiskHttpApi(token);

            var rootFolderData = await api.MetaInfo.GetInfoAsync(new ResourceRequest
            {
                Path = "/" + folderName + "/"
            });


            foreach (var item in rootFolderData.Embedded.Items)
            {
                if (item.Name == disciplineTitle)
                {
                    DeleteFileRequest disciplineDirectory = new DeleteFileRequest();


                    disciplineDirectory.Path = item.Path;
                    disciplineDirectory.Permanently = false;

                    await api.Commands.DeleteAsync(disciplineDirectory);
                }
            }
        }
    }
}
