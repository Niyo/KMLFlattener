using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMLFlattener.OverpassTurboExport
{


    // HINWEIS: Für den generierten Code ist möglicherweise mindestens .NET Framework 4.5 oder .NET Core/Standard 2.0 erforderlich.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/kml/2.2", IsNullable = false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocument
    {

        private string nameField;

        private string descriptionField;

        private kmlDocumentPlacemark[] placemarkField;

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
        [System.Xml.Serialization.XmlElementAttribute("Placemark")]
        public kmlDocumentPlacemark[] Placemark
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentPlacemark
    {

        private string nameField;

        private string descriptionField;

        private kmlDocumentPlacemarkData[] extendedDataField;

        private kmlDocumentPlacemarkPoint pointField;

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
        public kmlDocumentPlacemarkPoint Point
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentPlacemarkPoint
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
