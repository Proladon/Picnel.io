﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32; //FileDialog
using WinForms = System.Windows.Forms; //FolderDialog
using System.IO; //Folder, Directory
using System.Diagnostics; //Debug.WriteLine
using Picnel.io.Classes;
using WpfAnimatedGif;
using Picnel.io.User_Controls;
using System.Threading;
using Newtonsoft.Json;

namespace Picnel.io
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
            
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_DragMove(object sender, MouseButtonEventArgs e)
        {
            try
            {
                mainGrid.Focus();
                infoBtn.IsChecked = false;
                copyBtn.IsChecked = false;
                this.DragMove();
            }
            catch (System.InvalidOperationException)
            {
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Next按鈕 Next Button
        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            if (GloableObject.img_filename == string.Empty)
            {
                GloableObject.logger($"❌🔎 [Error][Loading File] - No File Exsit.");
                return;
            }
            //string path = targetFolder_path.Text.ToString();
            GloableObject.random_image(GloableObject.curPath);
            imgFileName.Text = GloableObject.img_filename;
        }

        // 選取主要路徑
        private void chooseTargetFolder_Btn_Click(object sender, RoutedEventArgs e)
        {
            preview_mode.IsChecked = false;
            WinForms.FolderBrowserDialog folderDialog = new WinForms.FolderBrowserDialog();
            folderDialog.ShowNewFolderButton = false;
            folderDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderDialog.SelectedPath = GloableObject.lastPath;
            WinForms.DialogResult result = folderDialog.ShowDialog();
            if (result == WinForms.DialogResult.Cancel)
            {
                return;
            }
            string sPath = folderDialog.SelectedPath;
            GloableObject.curPath = sPath;
            GloableObject.lastPath = sPath;
            GloableObject.random_image(sPath);
            GloableObject.folderInfo();
            GloableObject.logger($"✔⚙ [Set Main Directory] - Path: [ {sPath} ]", "HighLight");
        }

        // 新建目標資料夾 Create Target Control
        private void CreateControl_Click(object sender, RoutedEventArgs e)
        {
            CreateControl_Dialog test_create = new CreateControl_Dialog();
            Window newWin = new Window
            {
                Title = "Create test",
                Height = 250,
                Width = 600,
                Content = test_create,
                Topmost = true,
                WindowStyle = WindowStyle.None,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            newWin.ShowDialog();
        }

        // 重新命名 Rename
        private void imgFileName_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            GloableObject.preFileName = imgFileName.Text;
        }
        private void imgFileName_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (imgFileName.Text != GloableObject.preFileName)
            {
                try
                {
                    System.IO.File.Move(GloableObject.img_path, GloableObject.curPath + '\\' + imgFileName.Text);
                    GloableObject.logger($"✔🔁 [Renmae File] {GloableObject.img_filename} > {imgFileName.Text}");
                    System.IO.File.Delete(GloableObject.img_filename);
                    GloableObject.img_path = GloableObject.curPath + '\\' + imgFileName.Text;
                    GloableObject.img_filename = imgFileName.Text;
                }
                catch (System.IO.IOException)
                {
                    GloableObject.logger($"❌⚠ [Error] [ReName File] - File Has Been Exsit.");
                }
                catch (System.ArgumentException)
                {
                    GloableObject.logger($"❌⚠ [Error] [ReName File] - Can Not Empty File Name.");
                }
                finally
                {
                    imgFileName.Text = GloableObject.img_filename;
                }
            }
        }

        // 刪除檔案 Delte File
        private void deleteImg_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Delete File Forever?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                if (File.Exists(GloableObject.img_path))
                {
                    System.IO.File.Delete(GloableObject.img_path);
                    GloableObject.logger($"♻🗑 [Delete File] - FileName: [ {GloableObject.img_filename} ]");
                    GloableObject.random_image(GloableObject.curPath);
                    GloableObject.folderInfo();
                }
                else
                {
                    GloableObject.logger($"❌🗑 [Error] [Delete File] - Can't Not Delete, File Dosen't Exsit.");
                }
            }
        }

        // 視窗最大化 Windows Maximized
        private void winMaximized(object sender, RoutedEventArgs e)
        {
            if (GloableObject.winState == "Normal")
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
                GloableObject.winState = "Maximized";
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
                GloableObject.winState = "Normal";
            }
        }
        // 視窗最小化 Windows Minimized
        private void winMinimized(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        // 視窗透明度 Windows Opacity
        private void Opacity_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            string value = Convert.ToString(Convert.ToInt32(Opacity_slider.Value * 100)) + '%';
            Opacity_label.Text = value;
        }

        // 使用者設定按鈕 Settings Button
        private void settings_Btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorry, This Function Not Yet Complete.");
            /*
            User_Settings user_settings = new User_Settings();
            Window newWin = new Window
            {
                Title = "Create test",
                Height = 500,
                Width = 600,
                Content = user_settings,
                Topmost = true,
                WindowStyle = WindowStyle.None,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            newWin.ShowDialog();
            */
        }

        // 開啟檔案位置按鈕 Open File Location
        private void openImg_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(GloableObject.img_path))
            {
                Process.Start("explorer.exe", "/select, " + GloableObject.img_path);
            }
            else
            {
                GloableObject.logger($"❌📤 [Error] [Open File Location] - Can't Not Open, File Dosen't Exsit.");
            }
        }

        // 最愛路徑 Favorite Path
        private void favorit_Btn_Click(object sender, RoutedEventArgs e)
        {
            Favorite_Setting favorite_settings = new Favorite_Setting();
            Window newWin = new Window
            {
                Height = 500,
                Width = 400,
                Content = favorite_settings,
                Topmost = true,
                WindowStyle = WindowStyle.None,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            
            if (Properties.Settings.Default.Favorite_Path_List != null)
            {
                foreach (string favorite in Properties.Settings.Default.Favorite_List)
                {
                    Favorite favor = new Favorite();
                    favor.Width = 300;
                    favor.Height = 60;
                    favor.favorite_aka.Text = favorite;
               
                    foreach (string path in Properties.Settings.Default.Favorite_Path_List)
                    {
                        string[] ary = path.Split(':','"');
                        string key = ary[1].ToString();

                        if (key == favorite)
                        {
                            Dictionary<string, string> favor_path_data = (Dictionary<string, string>)JsonConvert.DeserializeObject(path, typeof(Dictionary<string, string>));
                            favor.favorite_path.Text = favor_path_data[favorite];
                        }
                    }
                    favorite_settings.favorite_list_panel.Children.Add(favor);
                }
            }

            if (Properties.Settings.Default.Current_Favorite != "None")
            {
                Favorite cur_favorite = new Favorite();
                cur_favorite.Margin = new Thickness(10, 10, 10, 10);
                cur_favorite.favorite_aka.Text = Properties.Settings.Default.Current_Favorite;
                cur_favorite.favorite_path.Text = GloableObject.curPath;
                cur_favorite.favorite_delete_btn.IsHitTestVisible = false;
                cur_favorite.favorite_btn.IsHitTestVisible = false;
                Grid.SetRow(cur_favorite, 2);
                favorite_settings.cur_none.Visibility = Visibility.Collapsed;
                favorite_settings.favorite_settings_grid.Children.Add(cur_favorite);
            }

            newWin.ShowDialog();
        }

        // DarkMode 切換
        private void Mode_Change(SolidColorBrush color_1, SolidColorBrush color_2, bool toggle)
        {
            mainGrid.Background = color_2;
            controlPanel_Splitter.Background = color_2;
            targetFolder_path.Foreground = color_1;
            Opacity_label.Foreground = color_1;
            version_label.Foreground = color_1;
            logger_label.Foreground = color_1;
            Properties.Settings.Default.DarkMode = toggle;
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            
            SolidColorBrush dark = (SolidColorBrush)Application.Current.FindResource("dark");
            Mode_Change(dark, Brushes.White, true);
        }
        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            SolidColorBrush dark = (SolidColorBrush)Application.Current.FindResource("dark");
            Mode_Change(Brushes.White, dark, false);
        }


        // 複製工具
        private void copyBtn_LostFocus(object sender, RoutedEventArgs e)
        {
            copyBtn.IsChecked = false;
        }
        // 複製圖片路徑
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (GloableObject.img_path == string.Empty)
            {
                GloableObject.logger($"❌📑 [Error] [Copy File Path] - No File Exsit.");
            }
            else
            {
                Clipboard.SetText(GloableObject.img_path);
                GloableObject.logger($"✔📑 [Error] [Copy File Path] - Copy [ {GloableObject.img_path} ] To ClipBoard.");
                copyBtn.IsChecked = false;
            }
        }
        // 複製圖片
        private void copy_img_Click(object sender, RoutedEventArgs e)
        {
            if (GloableObject.img == null)
            {
                copyBtn.IsChecked = false;
                GloableObject.logger("❌📑 [Error] [Copy Image] - No Image Exsit.");
                return;
            }
            else
            {
                var image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = new Uri(GloableObject.img_path);
                image.EndInit();
                Clipboard.SetImage(image);
                GC.Collect();
                GloableObject.logger($"✔📑 [Copy Image] - Copy [ {GloableObject.img_filename} ] To ClipBoard.");
                copyBtn.IsChecked = false;
            }
        }


        // 至頂視窗 Most On Top
        private void topmose_Btn_Checked(object sender, RoutedEventArgs e)
        {
            appWindow.Topmost = true;
        }
        private void topmose_Btn_Unchecked(object sender, RoutedEventArgs e)
        {
            appWindow.Topmost = false;
        }
        private void Window_Deactivated(object sender, EventArgs e)
        {
            copyBtn.IsChecked = false;
            infoBtn.IsChecked = false;
            this.Opacity = 0.8;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        // Settings Data Debug
        // 清除所有設定
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("This Will Clean All Settings, Are You Sure?", "!!WARNING!!", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                Properties.Settings.Default.Current_Favorite = "None";
                Properties.Settings.Default.Favorite_List = null;
                Properties.Settings.Default.Favorite_Path_List = null;
                Properties.Settings.Default.Favorite_Controls_List = null;
                Properties.Settings.Default.Save();
            }
        }

        // 說明文件 Documentation
        private void Documentation_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://proladon.gitbook.io/picnel-io/document-shui-ming-wen-jian");
        }

        private void infoBtn_LostFocus(object sender, RoutedEventArgs e)
        {
            infoBtn.IsChecked = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WebBrowser web = new WebBrowser();
            System.Diagnostics.Process.Start("https://proladon.gitbook.io/picnel-io/changelog-geng-xin-ri-zhi");
        }


        // 資料夾拖曳進Target Folder
        private void ScrollViewer_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file_path in files)
                {
                    string filename = System.IO.Path.GetFileName(file_path);
                    // 判斷是否為資料夾
                    if (System.IO.Path.GetExtension(filename) == string.Empty)
                    {
                        // 生成Controls
                        Folder_Control folder_Control = new Folder_Control();
                        folder_Control.akaLabel.Text = filename;
                        folder_Control.folderPath.Text = file_path;
                        folder_Control.ToolTip = file_path;
                        folder_Control.Height = 25;
                        control_panel.Children.Add(folder_Control);
                        GloableObject.logger($"✔🕹[Create Target Folder Control] AKA :[{filename}] ; Path: [{file_path}]");
                    }
                }
            }
        }

        // 資料夾拖曳進 Image Viewer / Main Folder
        private void Grid_Drop(object sender, DragEventArgs e)
        {
            preview_mode.IsChecked = false;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length == 1)
                {
                    string file = files[0];
                    string filename = System.IO.Path.GetFileName(file);
                    string file_ex = System.IO.Path.GetExtension(filename);
                    if (file_ex != string.Empty)
                    {
                        GloableObject.change_src(file);
                        folder_info.Text = "...";
                        targetFolder_path.Text = System.IO.Path.GetFileName(file);
                        targetFolder_path.ToolTip = file;
                        GloableObject.logger($"✔🔽 [Load File] - Loaded:[{filename}] Path:[{file}]");
                    }
                    else
                    {
                        GloableObject.curPath = file;
                        GloableObject.random_image(file + '\\');
                        targetFolder_path.Text = file;
                        GloableObject.logger($"✔🔽 [Load Folder] - Loaded:[{filename}] Path:[{file}]");
                        GloableObject.logger($"✔⚙ [Set Main Directory] - Path: [ {file} ]", "HighLight");
                        GloableObject.folderInfo();
                    }

                }
                else
                {
                    MessageBox.Show("Only Can Drop One File / Folder.");
                    return;
                }
            }
        }

        // 關閉程式
        private void appWindow_Closed(object sender, EventArgs e)
        {
            Properties.Settings.Default.Current_Favorite = "None";
            Properties.Settings.Default.Save();
        }

        // 圖片瀏覽模式
        // 前後
        private void preview_mode_Checked(object sender, RoutedEventArgs e)
        {
            if (GloableObject.curPath == string.Empty)
            {
                preview_mode.IsChecked = false;
                GloableObject.logger($"❌ [Error] - NotFound Directory. Pls Choose The Main Directoy");
                return;
            }
            else if (GloableObject.curPath != string.Empty || GloableObject.curPath != null)
            {
                GloableObject.file_list = new List<string>(Directory.GetFiles(GloableObject.curPath, "*", SearchOption.TopDirectoryOnly));
                GloableObject.cur_img_position = GloableObject.file_list.IndexOf(GloableObject.img_path);
            }
            randomBtn.Visibility = Visibility.Collapsed;
            pre_img.Visibility = Visibility.Visible;
            next_img.Visibility = Visibility.Visible;
        }
        // 隨機
        private void preview_mode_Unchecked(object sender, RoutedEventArgs e)
        {
            GloableObject.file_list = null;
            randomBtn.Visibility = Visibility.Visible;
            pre_img.Visibility = Visibility.Collapsed;
            next_img.Visibility = Visibility.Collapsed;
            GC.Collect();
        }
        // Pre Img
        private void pre_img_Click(object sender, RoutedEventArgs e)
        {
            if (GloableObject.cur_img_position > 0)
            {
                GloableObject.cur_img_position--;
                GloableObject.change_img(GloableObject.file_list[GloableObject.cur_img_position]);
            }
        }
        // Next Img
        private void next_img_Click(object sender, RoutedEventArgs e)
        {
            if (GloableObject.cur_img_position == 0 || GloableObject.cur_img_position < GloableObject.file_list.Count()-1)
            {
                GloableObject.cur_img_position ++;
                GloableObject.change_img(GloableObject.file_list[GloableObject.cur_img_position]);
            }
        }

    }
}
