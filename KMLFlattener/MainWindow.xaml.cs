using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;

namespace KMLFlattener
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            // Configure open file dialog box
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            //dlg.FileName = "KML File"; // Default file name
            //dlg.DefaultExt = ".kml"; // Default file extension
            //dlg.Filter = "KML (.kml)|*.kml"; // Filter files by extension

            // Show open file dialog box
            bool? result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                TxtFilePath.Text = dlg.FileName;
            }
        }

        private void BtnFlatten_Click(object sender, RoutedEventArgs e)
        {
            var filePath = TxtFilePath.Text;

            if (!File.Exists(filePath))
                MessageBox.Show("Invalid Filepath!");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(kml));

            kml oldKmlFile;

            using (var stream = File.OpenRead(filePath))
            {
                using (XmlTextReader reader = new XmlTextReader(stream))
                {
                    reader.Namespaces = false;
                    oldKmlFile = xmlSerializer.Deserialize(reader) as kml;
                }
            }

            if (oldKmlFile == null)
                MessageBox.Show("Invalid KML file!");

            flattenKml(oldKmlFile);

            string newFileName = "New_" + Path.GetFileNameWithoutExtension(filePath) + ".kml";

            var encoding = Encoding.GetEncoding("UTF-8");

            using (StreamWriter stream = new StreamWriter(newFileName, false, encoding))
            {
                xmlSerializer.Serialize(stream, oldKmlFile);
            }

            var path = Path.Combine(Directory.GetCurrentDirectory(), newFileName);
            MessageBox.Show($"Successful flattened kml file. Path: {path}");
        }

        private void flattenKml(kml kmlFile)
        {
            if (kmlFile.Document.Folder == null)
                return;

             var flattenedPlacemarks = kmlFile.Document.Folder.SelectMany(d => d.Placemark);

            if (kmlFile.Document.Placemark == null)
            {
                kmlFile.Document.Placemark = flattenedPlacemarks.ToArray();
            }
            else // merge placemarks
            {
                List<kmlDocumentFolderPlacemark> newPlaceMarks = new List<kmlDocumentFolderPlacemark>(kmlFile.Document.Placemark);

                newPlaceMarks.AddRange(flattenedPlacemarks);

                kmlFile.Document.Placemark = newPlaceMarks.ToArray();
            }

            kmlFile.Document.Folder = null;
        }
    }
}
