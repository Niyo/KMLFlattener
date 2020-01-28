using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace KMLFlattener.WikipediaExport
{

    // HINWEIS: Für den generierten Code ist möglicherweise mindestens .NET Framework 4.5 oder .NET Core/Standard 2.0 erforderlich.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true/*, Namespace = "http://earth.google.com/kml/2.1"*/)]
    [System.Xml.Serialization.XmlRootAttribute(/*Namespace = "http://earth.google.com/kml/2.1",*/ IsNullable = false)]
    public partial class kml
    {

        private kmlDocument documentField;

        /// <remarks/>
        public kmlDocument Document
        {
            get
            {
                return this.documentField;
            }
            set
            {
                this.documentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true/*, Namespace = "http://earth.google.com/kml/2.1"*/)]
    public partial class kmlDocument
    {

        private string nameField;

        private byte openField;

        private string descriptionField;

        private kmlDocumentFolder[] folderField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public byte open
        {
            get
            {
                return this.openField;
            }
            set
            {
                this.openField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Folder")]
        public kmlDocumentFolder[] Folder
        {
            get
            {
                return this.folderField;
            }
            set
            {
                this.folderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Placemark")]
        public kmlDocumentFolderPlacemark[] Placemark
        {
            get;
            set;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true/*, Namespace = "http://earth.google.com/kml/2.1"*/)]
    public partial class kmlDocumentFolder
    {

        private string nameField;

        private byte openField;

        private kmlDocumentFolderPlacemark[] placemarkField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public byte open
        {
            get
            {
                return this.openField;
            }
            set
            {
                this.openField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Placemark")]
        public kmlDocumentFolderPlacemark[] Placemark
        {
            get
            {
                return this.placemarkField;
            }
            set
            {
                this.placemarkField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true/*, Namespace = "http://earth.google.com/kml/2.1"*/)]
    public partial class kmlDocumentFolderPlacemark
    {

        //private string nameField;

        private kmlDocumentFolderPlacemarkPoint pointField;

        private object snippetField;
        private kmlDocumentPlacemarkData[] extendedDataField;

        //private string descriptionField;

        /// <remarks/>
        public string name
        {
            get;
            //{
            //    return this.nameField;
            //}
            set;
            //{
            //    this.nameField = value;
            //}
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Data", IsNullable = false)]
        public kmlDocumentPlacemarkData[] ExtendedData
        {
            get
            {
                return this.extendedDataField;
            }
            set
            {
                this.extendedDataField = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderPlacemarkPoint Point
        {
            get
            {
                return this.pointField;
            }
            set
            {
                this.pointField = value;
            }
        }

        /// <remarks/>
        public object Snippet
        {
            get
            {
                return this.snippetField;
            }
            set
            {
                this.snippetField = value;
            }
        }

        //XmlCDataSection
        /// <remarks/>
        public string description
        {
            get;
            //{
            //    return this.descriptionField;
            //}
            set;
            //{
            //    this.descriptionField = value;
            //}
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true/*, Namespace = "http://www.opengis.net/kml/2.2"*/)]
    public partial class kmlDocumentPlacemarkData
    {

        private string valueField;

        private string nameField;

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true/*, Namespace = "http://earth.google.com/kml/2.1"*/)]
    public partial class kmlDocumentFolderPlacemarkPoint
    {

        private string coordinatesField;

        /// <remarks/>
        public string coordinates
        {
            get
            {
                return this.coordinatesField;
            }
            set
            {
                this.coordinatesField = value;
            }
        }
    }


}
