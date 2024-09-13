using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMLFlattener.KmlWithStyles
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
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

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Folder", typeof(kmlDocumentFolder))]
        [System.Xml.Serialization.XmlElementAttribute("Style", typeof(kmlDocumentStyle))]
        [System.Xml.Serialization.XmlElementAttribute("StyleMap", typeof(kmlDocumentStyleMap))]
        [System.Xml.Serialization.XmlElementAttribute("name", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("open", typeof(byte))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolder
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Folder", typeof(kmlDocumentFolderFolder))]
        [System.Xml.Serialization.XmlElementAttribute("Placemark", typeof(kmlDocumentFolderPlacemark))]
        [System.Xml.Serialization.XmlElementAttribute("Style", typeof(kmlDocumentFolderStyle))]
        [System.Xml.Serialization.XmlElementAttribute("name", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("open", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("visibility", typeof(byte))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolder
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Document", typeof(kmlDocumentFolderFolderDocument))]
        [System.Xml.Serialization.XmlElementAttribute("Folder", typeof(kmlDocumentFolderFolderFolder))]
        [System.Xml.Serialization.XmlElementAttribute("Placemark", typeof(kmlDocumentFolderFolderPlacemark))]
        [System.Xml.Serialization.XmlElementAttribute("Style", typeof(kmlDocumentFolderFolderStyle))]
        [System.Xml.Serialization.XmlElementAttribute("name", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("visibility", typeof(byte))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocument
    {

        private string nameField;

        private kmlDocumentFolderFolderDocumentStyleMap[] styleMapField;

        private kmlDocumentFolderFolderDocumentStyle[] styleField;

        private kmlDocumentFolderFolderDocumentFolder folderField;

        private kmlDocumentFolderFolderDocumentDocument documentField;

        private string idField;

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
        [System.Xml.Serialization.XmlElementAttribute("StyleMap")]
        public kmlDocumentFolderFolderDocumentStyleMap[] StyleMap
        {
            get
            {
                return this.styleMapField;
            }
            set
            {
                this.styleMapField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Style")]
        public kmlDocumentFolderFolderDocumentStyle[] Style
        {
            get
            {
                return this.styleField;
            }
            set
            {
                this.styleField = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderFolderDocumentFolder Folder
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
        public kmlDocumentFolderFolderDocumentDocument Document
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentStyleMap
    {

        private kmlDocumentFolderFolderDocumentStyleMapPair[] pairField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Pair")]
        public kmlDocumentFolderFolderDocumentStyleMapPair[] Pair
        {
            get
            {
                return this.pairField;
            }
            set
            {
                this.pairField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentStyleMapPair
    {

        private string keyField;

        private string styleUrlField;

        /// <remarks/>
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        public string styleUrl
        {
            get
            {
                return this.styleUrlField;
            }
            set
            {
                this.styleUrlField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentStyle
    {

        private kmlDocumentFolderFolderDocumentStyleIconStyle iconStyleField;

        private kmlDocumentFolderFolderDocumentStyleLineStyle lineStyleField;

        private kmlDocumentFolderFolderDocumentStylePolyStyle polyStyleField;

        private string idField;

        /// <remarks/>
        public kmlDocumentFolderFolderDocumentStyleIconStyle IconStyle
        {
            get
            {
                return this.iconStyleField;
            }
            set
            {
                this.iconStyleField = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderFolderDocumentStyleLineStyle LineStyle
        {
            get
            {
                return this.lineStyleField;
            }
            set
            {
                this.lineStyleField = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderFolderDocumentStylePolyStyle PolyStyle
        {
            get
            {
                return this.polyStyleField;
            }
            set
            {
                this.polyStyleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentStyleIconStyle
    {

        private decimal scaleField;

        private kmlDocumentFolderFolderDocumentStyleIconStyleIcon iconField;

        /// <remarks/>
        public decimal scale
        {
            get
            {
                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderFolderDocumentStyleIconStyleIcon Icon
        {
            get
            {
                return this.iconField;
            }
            set
            {
                this.iconField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentStyleIconStyleIcon
    {

        private string hrefField;

        /// <remarks/>
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentStyleLineStyle
    {

        private string colorField;

        private decimal widthField;

        private bool widthFieldSpecified;

        /// <remarks/>
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentStylePolyStyle
    {

        private string colorField;

        /// <remarks/>
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentFolder
    {

        private string nameField;

        private kmlDocumentFolderFolderDocumentFolderPlacemark[] placemarkField;

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
        [System.Xml.Serialization.XmlElementAttribute("Placemark")]
        public kmlDocumentFolderFolderDocumentFolderPlacemark[] Placemark
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
    public partial class kmlDocumentFolderFolderDocumentFolderPlacemark
    {

        private string styleUrlField;

        private kmlDocumentFolderFolderDocumentFolderPlacemarkPoint pointField;

        private kmlDocumentFolderFolderDocumentFolderPlacemarkMultiGeometry multiGeometryField;

        /// <remarks/>
        public string styleUrl
        {
            get
            {
                return this.styleUrlField;
            }
            set
            {
                this.styleUrlField = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderFolderDocumentFolderPlacemarkPoint Point
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
        public kmlDocumentFolderFolderDocumentFolderPlacemarkMultiGeometry MultiGeometry
        {
            get
            {
                return this.multiGeometryField;
            }
            set
            {
                this.multiGeometryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentFolderPlacemarkPoint
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentFolderPlacemarkMultiGeometry
    {

        private kmlDocumentFolderFolderDocumentFolderPlacemarkMultiGeometryPolygon polygonField;

        private kmlDocumentFolderFolderDocumentFolderPlacemarkMultiGeometryLineString lineStringField;

        /// <remarks/>
        public kmlDocumentFolderFolderDocumentFolderPlacemarkMultiGeometryPolygon Polygon
        {
            get
            {
                return this.polygonField;
            }
            set
            {
                this.polygonField = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderFolderDocumentFolderPlacemarkMultiGeometryLineString LineString
        {
            get
            {
                return this.lineStringField;
            }
            set
            {
                this.lineStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentFolderPlacemarkMultiGeometryPolygon
    {

        private kmlDocumentFolderFolderDocumentFolderPlacemarkMultiGeometryPolygonOuterBoundaryIs outerBoundaryIsField;

        /// <remarks/>
        public kmlDocumentFolderFolderDocumentFolderPlacemarkMultiGeometryPolygonOuterBoundaryIs outerBoundaryIs
        {
            get
            {
                return this.outerBoundaryIsField;
            }
            set
            {
                this.outerBoundaryIsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentFolderPlacemarkMultiGeometryPolygonOuterBoundaryIs
    {

        private kmlDocumentFolderFolderDocumentFolderPlacemarkMultiGeometryPolygonOuterBoundaryIsLinearRing linearRingField;

        /// <remarks/>
        public kmlDocumentFolderFolderDocumentFolderPlacemarkMultiGeometryPolygonOuterBoundaryIsLinearRing LinearRing
        {
            get
            {
                return this.linearRingField;
            }
            set
            {
                this.linearRingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentFolderPlacemarkMultiGeometryPolygonOuterBoundaryIsLinearRing
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentFolderPlacemarkMultiGeometryLineString
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentDocument
    {

        private string nameField;

        private kmlDocumentFolderFolderDocumentDocumentStyleMap styleMapField;

        private kmlDocumentFolderFolderDocumentDocumentStyle[] styleField;

        private kmlDocumentFolderFolderDocumentDocumentPlacemark[] placemarkField;

        private string idField;

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
        public kmlDocumentFolderFolderDocumentDocumentStyleMap StyleMap
        {
            get
            {
                return this.styleMapField;
            }
            set
            {
                this.styleMapField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Style")]
        public kmlDocumentFolderFolderDocumentDocumentStyle[] Style
        {
            get
            {
                return this.styleField;
            }
            set
            {
                this.styleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Placemark")]
        public kmlDocumentFolderFolderDocumentDocumentPlacemark[] Placemark
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentDocumentStyleMap
    {

        private kmlDocumentFolderFolderDocumentDocumentStyleMapPair[] pairField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Pair")]
        public kmlDocumentFolderFolderDocumentDocumentStyleMapPair[] Pair
        {
            get
            {
                return this.pairField;
            }
            set
            {
                this.pairField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentDocumentStyleMapPair
    {

        private string keyField;

        private string styleUrlField;

        /// <remarks/>
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        public string styleUrl
        {
            get
            {
                return this.styleUrlField;
            }
            set
            {
                this.styleUrlField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentDocumentStyle
    {

        private kmlDocumentFolderFolderDocumentDocumentStyleIconStyle iconStyleField;

        private kmlDocumentFolderFolderDocumentDocumentStyleLineStyle lineStyleField;

        private string idField;

        /// <remarks/>
        public kmlDocumentFolderFolderDocumentDocumentStyleIconStyle IconStyle
        {
            get
            {
                return this.iconStyleField;
            }
            set
            {
                this.iconStyleField = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderFolderDocumentDocumentStyleLineStyle LineStyle
        {
            get
            {
                return this.lineStyleField;
            }
            set
            {
                this.lineStyleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentDocumentStyleIconStyle
    {

        private decimal scaleField;

        private kmlDocumentFolderFolderDocumentDocumentStyleIconStyleIcon iconField;

        /// <remarks/>
        public decimal scale
        {
            get
            {
                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderFolderDocumentDocumentStyleIconStyleIcon Icon
        {
            get
            {
                return this.iconField;
            }
            set
            {
                this.iconField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentDocumentStyleIconStyleIcon
    {

        private string hrefField;

        /// <remarks/>
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentDocumentStyleLineStyle
    {

        private string colorField;

        private decimal widthField;

        /// <remarks/>
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentDocumentPlacemark
    {

        private string styleUrlField;

        private kmlDocumentFolderFolderDocumentDocumentPlacemarkLineString lineStringField;

        private string idField;

        /// <remarks/>
        public string styleUrl
        {
            get
            {
                return this.styleUrlField;
            }
            set
            {
                this.styleUrlField = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderFolderDocumentDocumentPlacemarkLineString LineString
        {
            get
            {
                return this.lineStringField;
            }
            set
            {
                this.lineStringField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderDocumentDocumentPlacemarkLineString
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderFolder
    {

        private string nameField;

        private kmlDocumentFolderFolderFolderStyle styleField;

        private kmlDocumentFolderFolderFolderPlacemark[] placemarkField;

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
        public kmlDocumentFolderFolderFolderStyle Style
        {
            get
            {
                return this.styleField;
            }
            set
            {
                this.styleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Placemark")]
        public kmlDocumentFolderFolderFolderPlacemark[] Placemark
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
    public partial class kmlDocumentFolderFolderFolderStyle
    {

        private kmlDocumentFolderFolderFolderStyleListStyle listStyleField;

        /// <remarks/>
        public kmlDocumentFolderFolderFolderStyleListStyle ListStyle
        {
            get
            {
                return this.listStyleField;
            }
            set
            {
                this.listStyleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderFolderStyleListStyle
    {

        private string listItemTypeField;

        private string bgColorField;

        private byte maxSnippetLinesField;

        /// <remarks/>
        public string listItemType
        {
            get
            {
                return this.listItemTypeField;
            }
            set
            {
                this.listItemTypeField = value;
            }
        }

        /// <remarks/>
        public string bgColor
        {
            get
            {
                return this.bgColorField;
            }
            set
            {
                this.bgColorField = value;
            }
        }

        /// <remarks/>
        public byte maxSnippetLines
        {
            get
            {
                return this.maxSnippetLinesField;
            }
            set
            {
                this.maxSnippetLinesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderFolderPlacemark
    {

        private string nameField;

        private string descriptionField;

        private string styleUrlField;

        private kmlDocumentFolderFolderFolderPlacemarkPoint pointField;

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
        public string styleUrl
        {
            get
            {
                return this.styleUrlField;
            }
            set
            {
                this.styleUrlField = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderFolderFolderPlacemarkPoint Point
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
    public partial class kmlDocumentFolderFolderFolderPlacemarkPoint
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderPlacemark
    {

        private string nameField;

        private byte visibilityField;

        private bool visibilityFieldSpecified;

        private kmlDocumentFolderFolderPlacemarkSnippet snippetField;

        private byte openField;

        private bool openFieldSpecified;

        private kmlDocumentFolderFolderPlacemarkLookAt lookAtField;

        private string descriptionField;

        private string styleUrlField;

        private kmlDocumentFolderFolderPlacemarkPolygon polygonField;

        private kmlDocumentFolderFolderPlacemarkLineString lineStringField;

        private kmlDocumentFolderFolderPlacemarkPoint pointField;

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
        public byte visibility
        {
            get
            {
                return this.visibilityField;
            }
            set
            {
                this.visibilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool visibilitySpecified
        {
            get
            {
                return this.visibilityFieldSpecified;
            }
            set
            {
                this.visibilityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderFolderPlacemarkSnippet Snippet
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool openSpecified
        {
            get
            {
                return this.openFieldSpecified;
            }
            set
            {
                this.openFieldSpecified = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderFolderPlacemarkLookAt LookAt
        {
            get
            {
                return this.lookAtField;
            }
            set
            {
                this.lookAtField = value;
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
        public string styleUrl
        {
            get
            {
                return this.styleUrlField;
            }
            set
            {
                this.styleUrlField = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderFolderPlacemarkPolygon Polygon
        {
            get
            {
                return this.polygonField;
            }
            set
            {
                this.polygonField = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderFolderPlacemarkLineString LineString
        {
            get
            {
                return this.lineStringField;
            }
            set
            {
                this.lineStringField = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderFolderPlacemarkPoint Point
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
    public partial class kmlDocumentFolderFolderPlacemarkSnippet
    {

        private byte maxLinesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte maxLines
        {
            get
            {
                return this.maxLinesField;
            }
            set
            {
                this.maxLinesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderPlacemarkLookAt
    {

        private decimal longitudeField;

        private decimal latitudeField;

        private byte altitudeField;

        private decimal headingField;

        private byte tiltField;

        private decimal rangeField;

        private string altitudeModeField;

        /// <remarks/>
        public decimal longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        public decimal latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        public byte altitude
        {
            get
            {
                return this.altitudeField;
            }
            set
            {
                this.altitudeField = value;
            }
        }

        /// <remarks/>
        public decimal heading
        {
            get
            {
                return this.headingField;
            }
            set
            {
                this.headingField = value;
            }
        }

        /// <remarks/>
        public byte tilt
        {
            get
            {
                return this.tiltField;
            }
            set
            {
                this.tiltField = value;
            }
        }

        /// <remarks/>
        public decimal range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.google.com/kml/ext/2.2")]
        public string altitudeMode
        {
            get
            {
                return this.altitudeModeField;
            }
            set
            {
                this.altitudeModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderPlacemarkPolygon
    {

        private byte tessellateField;

        private byte drawOrderField;

        private bool drawOrderFieldSpecified;

        private kmlDocumentFolderFolderPlacemarkPolygonOuterBoundaryIs outerBoundaryIsField;

        /// <remarks/>
        public byte tessellate
        {
            get
            {
                return this.tessellateField;
            }
            set
            {
                this.tessellateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.google.com/kml/ext/2.2")]
        public byte drawOrder
        {
            get
            {
                return this.drawOrderField;
            }
            set
            {
                this.drawOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool drawOrderSpecified
        {
            get
            {
                return this.drawOrderFieldSpecified;
            }
            set
            {
                this.drawOrderFieldSpecified = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderFolderPlacemarkPolygonOuterBoundaryIs outerBoundaryIs
        {
            get
            {
                return this.outerBoundaryIsField;
            }
            set
            {
                this.outerBoundaryIsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderPlacemarkPolygonOuterBoundaryIs
    {

        private kmlDocumentFolderFolderPlacemarkPolygonOuterBoundaryIsLinearRing linearRingField;

        /// <remarks/>
        public kmlDocumentFolderFolderPlacemarkPolygonOuterBoundaryIsLinearRing LinearRing
        {
            get
            {
                return this.linearRingField;
            }
            set
            {
                this.linearRingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderPlacemarkPolygonOuterBoundaryIsLinearRing
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderPlacemarkLineString
    {

        private byte tessellateField;

        private bool tessellateFieldSpecified;

        private string coordinatesField;

        /// <remarks/>
        public byte tessellate
        {
            get
            {
                return this.tessellateField;
            }
            set
            {
                this.tessellateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tessellateSpecified
        {
            get
            {
                return this.tessellateFieldSpecified;
            }
            set
            {
                this.tessellateFieldSpecified = value;
            }
        }

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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderPlacemarkPoint
    {

        private string altitudeModeField;

        private string altitudeMode1Field;

        private byte drawOrderField;

        private bool drawOrderFieldSpecified;

        private string coordinatesField;

        /// <remarks/>
        public string altitudeMode
        {
            get
            {
                return this.altitudeModeField;
            }
            set
            {
                this.altitudeModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("altitudeMode", Namespace = "http://www.google.com/kml/ext/2.2")]
        public string altitudeMode1
        {
            get
            {
                return this.altitudeMode1Field;
            }
            set
            {
                this.altitudeMode1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.google.com/kml/ext/2.2")]
        public byte drawOrder
        {
            get
            {
                return this.drawOrderField;
            }
            set
            {
                this.drawOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool drawOrderSpecified
        {
            get
            {
                return this.drawOrderFieldSpecified;
            }
            set
            {
                this.drawOrderFieldSpecified = value;
            }
        }

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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderStyle
    {

        private kmlDocumentFolderFolderStyleListStyle listStyleField;

        /// <remarks/>
        public kmlDocumentFolderFolderStyleListStyle ListStyle
        {
            get
            {
                return this.listStyleField;
            }
            set
            {
                this.listStyleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderFolderStyleListStyle
    {

        private string listItemTypeField;

        private string bgColorField;

        private byte maxSnippetLinesField;

        /// <remarks/>
        public string listItemType
        {
            get
            {
                return this.listItemTypeField;
            }
            set
            {
                this.listItemTypeField = value;
            }
        }

        /// <remarks/>
        public string bgColor
        {
            get
            {
                return this.bgColorField;
            }
            set
            {
                this.bgColorField = value;
            }
        }

        /// <remarks/>
        public byte maxSnippetLines
        {
            get
            {
                return this.maxSnippetLinesField;
            }
            set
            {
                this.maxSnippetLinesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderPlacemark
    {

        private string nameField;

        private kmlDocumentFolderPlacemarkSnippet snippetField;

        private byte openField;

        private bool openFieldSpecified;

        private string descriptionField;

        private kmlDocumentFolderPlacemarkLookAt lookAtField;

        private string styleUrlField;

        private kmlDocumentFolderPlacemarkLineString lineStringField;

        private kmlDocumentFolderPlacemarkPolygon polygonField;

        private kmlDocumentFolderPlacemarkPoint pointField;

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
        public kmlDocumentFolderPlacemarkSnippet Snippet
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool openSpecified
        {
            get
            {
                return this.openFieldSpecified;
            }
            set
            {
                this.openFieldSpecified = value;
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
        public kmlDocumentFolderPlacemarkLookAt LookAt
        {
            get
            {
                return this.lookAtField;
            }
            set
            {
                this.lookAtField = value;
            }
        }

        /// <remarks/>
        public string styleUrl
        {
            get
            {
                return this.styleUrlField;
            }
            set
            {
                this.styleUrlField = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderPlacemarkLineString LineString
        {
            get
            {
                return this.lineStringField;
            }
            set
            {
                this.lineStringField = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderPlacemarkPolygon Polygon
        {
            get
            {
                return this.polygonField;
            }
            set
            {
                this.polygonField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderPlacemarkSnippet
    {

        private byte maxLinesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte maxLines
        {
            get
            {
                return this.maxLinesField;
            }
            set
            {
                this.maxLinesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderPlacemarkLookAt
    {

        private decimal longitudeField;

        private decimal latitudeField;

        private byte altitudeField;

        private decimal headingField;

        private byte tiltField;

        private decimal rangeField;

        private string altitudeModeField;

        /// <remarks/>
        public decimal longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        public decimal latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        public byte altitude
        {
            get
            {
                return this.altitudeField;
            }
            set
            {
                this.altitudeField = value;
            }
        }

        /// <remarks/>
        public decimal heading
        {
            get
            {
                return this.headingField;
            }
            set
            {
                this.headingField = value;
            }
        }

        /// <remarks/>
        public byte tilt
        {
            get
            {
                return this.tiltField;
            }
            set
            {
                this.tiltField = value;
            }
        }

        /// <remarks/>
        public decimal range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.google.com/kml/ext/2.2")]
        public string altitudeMode
        {
            get
            {
                return this.altitudeModeField;
            }
            set
            {
                this.altitudeModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderPlacemarkLineString
    {

        private byte tessellateField;

        private string coordinatesField;

        /// <remarks/>
        public byte tessellate
        {
            get
            {
                return this.tessellateField;
            }
            set
            {
                this.tessellateField = value;
            }
        }

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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderPlacemarkPolygon
    {

        private byte tessellateField;

        private bool tessellateFieldSpecified;

        private byte drawOrderField;

        private bool drawOrderFieldSpecified;

        private kmlDocumentFolderPlacemarkPolygonOuterBoundaryIs outerBoundaryIsField;

        /// <remarks/>
        public byte tessellate
        {
            get
            {
                return this.tessellateField;
            }
            set
            {
                this.tessellateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tessellateSpecified
        {
            get
            {
                return this.tessellateFieldSpecified;
            }
            set
            {
                this.tessellateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.google.com/kml/ext/2.2")]
        public byte drawOrder
        {
            get
            {
                return this.drawOrderField;
            }
            set
            {
                this.drawOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool drawOrderSpecified
        {
            get
            {
                return this.drawOrderFieldSpecified;
            }
            set
            {
                this.drawOrderFieldSpecified = value;
            }
        }

        /// <remarks/>
        public kmlDocumentFolderPlacemarkPolygonOuterBoundaryIs outerBoundaryIs
        {
            get
            {
                return this.outerBoundaryIsField;
            }
            set
            {
                this.outerBoundaryIsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderPlacemarkPolygonOuterBoundaryIs
    {

        private kmlDocumentFolderPlacemarkPolygonOuterBoundaryIsLinearRing linearRingField;

        /// <remarks/>
        public kmlDocumentFolderPlacemarkPolygonOuterBoundaryIsLinearRing LinearRing
        {
            get
            {
                return this.linearRingField;
            }
            set
            {
                this.linearRingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderPlacemarkPolygonOuterBoundaryIsLinearRing
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderPlacemarkPoint
    {

        private byte drawOrderField;

        private bool drawOrderFieldSpecified;

        private string altitudeModeField;

        private string altitudeMode1Field;

        private string coordinatesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.google.com/kml/ext/2.2")]
        public byte drawOrder
        {
            get
            {
                return this.drawOrderField;
            }
            set
            {
                this.drawOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool drawOrderSpecified
        {
            get
            {
                return this.drawOrderFieldSpecified;
            }
            set
            {
                this.drawOrderFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string altitudeMode
        {
            get
            {
                return this.altitudeModeField;
            }
            set
            {
                this.altitudeModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("altitudeMode", Namespace = "http://www.google.com/kml/ext/2.2")]
        public string altitudeMode1
        {
            get
            {
                return this.altitudeMode1Field;
            }
            set
            {
                this.altitudeMode1Field = value;
            }
        }

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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderStyle
    {

        private kmlDocumentFolderStyleListStyle listStyleField;

        /// <remarks/>
        public kmlDocumentFolderStyleListStyle ListStyle
        {
            get
            {
                return this.listStyleField;
            }
            set
            {
                this.listStyleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentFolderStyleListStyle
    {

        private string listItemTypeField;

        private string bgColorField;

        private byte maxSnippetLinesField;

        /// <remarks/>
        public string listItemType
        {
            get
            {
                return this.listItemTypeField;
            }
            set
            {
                this.listItemTypeField = value;
            }
        }

        /// <remarks/>
        public string bgColor
        {
            get
            {
                return this.bgColorField;
            }
            set
            {
                this.bgColorField = value;
            }
        }

        /// <remarks/>
        public byte maxSnippetLines
        {
            get
            {
                return this.maxSnippetLinesField;
            }
            set
            {
                this.maxSnippetLinesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/kml/2.2", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        Folder,

        /// <remarks/>
        Placemark,

        /// <remarks/>
        Style,

        /// <remarks/>
        name,

        /// <remarks/>
        open,

        /// <remarks/>
        visibility,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentStyle
    {

        private object[] itemsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BalloonStyle", typeof(kmlDocumentStyleBalloonStyle))]
        [System.Xml.Serialization.XmlElementAttribute("IconStyle", typeof(kmlDocumentStyleIconStyle))]
        [System.Xml.Serialization.XmlElementAttribute("LabelStyle", typeof(kmlDocumentStyleLabelStyle))]
        [System.Xml.Serialization.XmlElementAttribute("LineStyle", typeof(kmlDocumentStyleLineStyle))]
        [System.Xml.Serialization.XmlElementAttribute("ListStyle", typeof(kmlDocumentStyleListStyle))]
        [System.Xml.Serialization.XmlElementAttribute("PolyStyle", typeof(kmlDocumentStylePolyStyle))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentStyleBalloonStyle
    {

        private string textField;

        private string bgColorField;

        /// <remarks/>
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        public string bgColor
        {
            get
            {
                return this.bgColorField;
            }
            set
            {
                this.bgColorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentStyleIconStyle
    {

        private string colorField;

        private decimal scaleField;

        private kmlDocumentStyleIconStyleIcon iconField;

        private kmlDocumentStyleIconStyleHotSpot hotSpotField;

        /// <remarks/>
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        public decimal scale
        {
            get
            {
                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
            }
        }

        /// <remarks/>
        public kmlDocumentStyleIconStyleIcon Icon
        {
            get
            {
                return this.iconField;
            }
            set
            {
                this.iconField = value;
            }
        }

        /// <remarks/>
        public kmlDocumentStyleIconStyleHotSpot hotSpot
        {
            get
            {
                return this.hotSpotField;
            }
            set
            {
                this.hotSpotField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentStyleIconStyleIcon
    {

        private string hrefField;

        /// <remarks/>
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentStyleIconStyleHotSpot
    {

        private byte xField;

        private byte yField;

        private string xunitsField;

        private string yunitsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xunits
        {
            get
            {
                return this.xunitsField;
            }
            set
            {
                this.xunitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string yunits
        {
            get
            {
                return this.yunitsField;
            }
            set
            {
                this.yunitsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentStyleLabelStyle
    {

        private decimal scaleField;

        /// <remarks/>
        public decimal scale
        {
            get
            {
                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentStyleLineStyle
    {

        private string colorField;

        private decimal widthField;

        private bool widthFieldSpecified;

        /// <remarks/>
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool widthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentStyleListStyle
    {

        private kmlDocumentStyleListStyleItemIcon itemIconField;

        private string listItemTypeField;

        /// <remarks/>
        public kmlDocumentStyleListStyleItemIcon ItemIcon
        {
            get
            {
                return this.itemIconField;
            }
            set
            {
                this.itemIconField = value;
            }
        }

        /// <remarks/>
        public string listItemType
        {
            get
            {
                return this.listItemTypeField;
            }
            set
            {
                this.listItemTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentStyleListStyleItemIcon
    {

        private string hrefField;

        /// <remarks/>
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentStylePolyStyle
    {

        private string colorField;

        private byte fillField;

        private bool fillFieldSpecified;

        /// <remarks/>
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        public byte fill
        {
            get
            {
                return this.fillField;
            }
            set
            {
                this.fillField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fillSpecified
        {
            get
            {
                return this.fillFieldSpecified;
            }
            set
            {
                this.fillFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentStyleMap
    {

        private kmlDocumentStyleMapPair[] pairField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Pair")]
        public kmlDocumentStyleMapPair[] Pair
        {
            get
            {
                return this.pairField;
            }
            set
            {
                this.pairField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
    public partial class kmlDocumentStyleMapPair
    {

        private string keyField;

        private string styleUrlField;

        /// <remarks/>
        public string key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        public string styleUrl
        {
            get
            {
                return this.styleUrlField;
            }
            set
            {
                this.styleUrlField = value;
            }
        }
    }


}
