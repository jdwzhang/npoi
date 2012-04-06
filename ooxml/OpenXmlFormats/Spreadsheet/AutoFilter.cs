// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>schemas</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace NPOI.OpenXmlFormats.Spreadsheet
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;



    public class CT_AutoFilter
    {

        private List<CT_FilterColumn> filterColumnField;

        private CT_SortState sortStateField;

        private CT_ExtensionList extLstField;

        private string refField;

        public CT_AutoFilter()
        {
            this.extLstField = new CT_ExtensionList();
            this.sortStateField = new CT_SortState();
            this.filterColumnField = new List<CT_FilterColumn>();
        }

        public List<CT_FilterColumn> filterColumn
        {
            get
            {
                return this.filterColumnField;
            }
            set
            {
                this.filterColumnField = value;
            }
        }

        public CT_SortState sortState
        {
            get
            {
                return this.sortStateField;
            }
            set
            {
                this.sortStateField = value;
            }
        }

        public CT_ExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }

        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    public class CT_FilterColumn
    {

        private object itemField;

        private uint colIdField;

        private bool hiddenButtonField;

        private bool showButtonField;

        public CT_FilterColumn()
        {
            this.hiddenButtonField = false;
            this.showButtonField = true;
        }

        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        public uint colId
        {
            get
            {
                return this.colIdField;
            }
            set
            {
                this.colIdField = value;
            }
        }

        [DefaultValue(false)]
        public bool hiddenButton
        {
            get
            {
                return this.hiddenButtonField;
            }
            set
            {
                this.hiddenButtonField = value;
            }
        }

        [DefaultValue(true)]
        public bool showButton
        {
            get
            {
                return this.showButtonField;
            }
            set
            {
                this.showButtonField = value;
            }
        }
    }

    public class CT_ColorFilter
    {

        private uint dxfIdField;

        private bool dxfIdFieldSpecified;

        private bool cellColorField;

        public CT_ColorFilter()
        {
            this.cellColorField = true;
        }

        public uint dxfId
        {
            get
            {
                return this.dxfIdField;
            }
            set
            {
                this.dxfIdField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnore]
        public bool dxfIdSpecified
        {
            get
            {
                return this.dxfIdFieldSpecified;
            }
            set
            {
                this.dxfIdFieldSpecified = value;
            }
        }

        [DefaultValue(true)]
        public bool cellColor
        {
            get
            {
                return this.cellColorField;
            }
            set
            {
                this.cellColorField = value;
            }
        }
    }

    public class CT_CustomFilters
    {

        private List<CT_CustomFilter> customFilterField;

        private bool andField;

        public CT_CustomFilters()
        {
            this.customFilterField = new List<CT_CustomFilter>();
            this.andField = false;
        }

        public List<CT_CustomFilter> customFilter
        {
            get
            {
                return this.customFilterField;
            }
            set
            {
                this.customFilterField = value;
            }
        }

        [DefaultValue(false)]
        public bool and
        {
            get
            {
                return this.andField;
            }
            set
            {
                this.andField = value;
            }
        }
    }

    public class CT_CustomFilter
    {

        private ST_FilterOperator operatorField;

        private string valField;

        public CT_CustomFilter()
        {
            this.operatorField = ST_FilterOperator.equal;
        }

        [DefaultValue(ST_FilterOperator.equal)]
        public ST_FilterOperator @operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
            }
        }

        public string val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }

    public enum ST_FilterOperator
    {

        /// <remarks/>
        equal,

        /// <remarks/>
        lessThan,

        /// <remarks/>
        lessThanOrEqual,

        /// <remarks/>
        notEqual,

        /// <remarks/>
        greaterThanOrEqual,

        /// <remarks/>
        greaterThan,
    }

    public class CT_DynamicFilter
    {

        private ST_DynamicFilterType typeField;

        private double valField;

        private bool valFieldSpecified;

        private double maxValField;

        private bool maxValFieldSpecified;

        public ST_DynamicFilterType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        public double val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnore]
        public bool valSpecified
        {
            get
            {
                return this.valFieldSpecified;
            }
            set
            {
                this.valFieldSpecified = value;
            }
        }

        public double maxVal
        {
            get
            {
                return this.maxValField;
            }
            set
            {
                this.maxValField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnore]
        public bool maxValSpecified
        {
            get
            {
                return this.maxValFieldSpecified;
            }
            set
            {
                this.maxValFieldSpecified = value;
            }
        }
    }

    public enum ST_DynamicFilterType
    {

        /// <remarks/>
        @null,

        /// <remarks/>
        aboveAverage,

        /// <remarks/>
        belowAverage,

        /// <remarks/>
        tomorrow,

        /// <remarks/>
        today,

        /// <remarks/>
        yesterday,

        /// <remarks/>
        nextWeek,

        /// <remarks/>
        thisWeek,

        /// <remarks/>
        lastWeek,

        /// <remarks/>
        nextMonth,

        /// <remarks/>
        thisMonth,

        /// <remarks/>
        lastMonth,

        /// <remarks/>
        nextQuarter,

        /// <remarks/>
        thisQuarter,

        /// <remarks/>
        lastQuarter,

        /// <remarks/>
        nextYear,

        /// <remarks/>
        thisYear,

        /// <remarks/>
        lastYear,

        /// <remarks/>
        yearToDate,

        /// <remarks/>
        Q1,

        /// <remarks/>
        Q2,

        /// <remarks/>
        Q3,

        /// <remarks/>
        Q4,

        /// <remarks/>
        M1,

        /// <remarks/>
        M2,

        /// <remarks/>
        M3,

        /// <remarks/>
        M4,

        /// <remarks/>
        M5,

        /// <remarks/>
        M6,

        /// <remarks/>
        M7,

        /// <remarks/>
        M8,

        /// <remarks/>
        M9,

        /// <remarks/>
        M10,

        /// <remarks/>
        M11,

        /// <remarks/>
        M12,
    }

    public class CT_Filters
    {

        private List<CT_Filter> filterField;

        private List<CT_DateGroupItem> dateGroupItemField;

        private bool blankField;

        private ST_CalendarType calendarTypeField;

        public CT_Filters()
        {
            this.dateGroupItemField = new List<CT_DateGroupItem>();
            this.filterField = new List<CT_Filter>();
            this.blankField = false;
            this.calendarTypeField = ST_CalendarType.none;
        }

        public List<CT_Filter> filter
        {
            get
            {
                return this.filterField;
            }
            set
            {
                this.filterField = value;
            }
        }

        public List<CT_DateGroupItem> dateGroupItem
        {
            get
            {
                return this.dateGroupItemField;
            }
            set
            {
                this.dateGroupItemField = value;
            }
        }

        [DefaultValue(false)]
        public bool blank
        {
            get
            {
                return this.blankField;
            }
            set
            {
                this.blankField = value;
            }
        }

        [DefaultValue(ST_CalendarType.none)]
        public ST_CalendarType calendarType
        {
            get
            {
                return this.calendarTypeField;
            }
            set
            {
                this.calendarTypeField = value;
            }
        }
    }

    public class CT_Filter
    {

        private string valField;

        public string val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }

    public class CT_DateGroupItem
    {

        private ushort yearField;

        private ushort monthField;

        private bool monthFieldSpecified;

        private ushort dayField;

        private bool dayFieldSpecified;

        private ushort hourField;

        private bool hourFieldSpecified;

        private ushort minuteField;

        private bool minuteFieldSpecified;

        private ushort secondField;

        private bool secondFieldSpecified;

        private ST_DateTimeGrouping dateTimeGroupingField;

        public ushort year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }

        public ushort month
        {
            get
            {
                return this.monthField;
            }
            set
            {
                this.monthField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnore]
        public bool monthSpecified
        {
            get
            {
                return this.monthFieldSpecified;
            }
            set
            {
                this.monthFieldSpecified = value;
            }
        }

        public ushort day
        {
            get
            {
                return this.dayField;
            }
            set
            {
                this.dayField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnore]
        public bool daySpecified
        {
            get
            {
                return this.dayFieldSpecified;
            }
            set
            {
                this.dayFieldSpecified = value;
            }
        }

        public ushort hour
        {
            get
            {
                return this.hourField;
            }
            set
            {
                this.hourField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnore]
        public bool hourSpecified
        {
            get
            {
                return this.hourFieldSpecified;
            }
            set
            {
                this.hourFieldSpecified = value;
            }
        }

        public ushort minute
        {
            get
            {
                return this.minuteField;
            }
            set
            {
                this.minuteField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnore]
        public bool minuteSpecified
        {
            get
            {
                return this.minuteFieldSpecified;
            }
            set
            {
                this.minuteFieldSpecified = value;
            }
        }

        public ushort second
        {
            get
            {
                return this.secondField;
            }
            set
            {
                this.secondField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnore]
        public bool secondSpecified
        {
            get
            {
                return this.secondFieldSpecified;
            }
            set
            {
                this.secondFieldSpecified = value;
            }
        }

        public ST_DateTimeGrouping dateTimeGrouping
        {
            get
            {
                return this.dateTimeGroupingField;
            }
            set
            {
                this.dateTimeGroupingField = value;
            }
        }
    }

    public enum ST_DateTimeGrouping
    {

        /// <remarks/>
        year,

        /// <remarks/>
        month,

        /// <remarks/>
        day,

        /// <remarks/>
        hour,

        /// <remarks/>
        minute,

        /// <remarks/>
        second,
    }
    
    public class CT_IconFilter
    {

        private ST_IconSetType iconSetField;

        private uint iconIdField;

        private bool iconIdFieldSpecified;

        public ST_IconSetType iconSet
        {
            get
            {
                return this.iconSetField;
            }
            set
            {
                this.iconSetField = value;
            }
        }

        public uint iconId
        {
            get
            {
                return this.iconIdField;
            }
            set
            {
                this.iconIdField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnore]
        public bool iconIdSpecified
        {
            get
            {
                return this.iconIdFieldSpecified;
            }
            set
            {
                this.iconIdFieldSpecified = value;
            }
        }
    }

    public enum ST_IconSetType
    {

        /// <remarks/>
        [XmlEnum("3Arrows")]
        Item3Arrows,

        /// <remarks/>
        [XmlEnum("3ArrowsGray")]
        Item3ArrowsGray,

        /// <remarks/>
        [XmlEnum("3Flags")]
        Item3Flags,

        /// <remarks/>
        [XmlEnum("3TrafficLights1")]
        Item3TrafficLights1,

        /// <remarks/>
        [XmlEnum("3TrafficLights2")]
        Item3TrafficLights2,

        /// <remarks/>
        [XmlEnum("3Signs")]
        Item3Signs,

        /// <remarks/>
        [XmlEnum("3Symbols")]
        Item3Symbols,

        /// <remarks/>
        [XmlEnum("3Symbols2")]
        Item3Symbols2,

        /// <remarks/>
        [XmlEnum("4Arrows")]
        Item4Arrows,

        /// <remarks/>
        [XmlEnum("4ArrowsGray")]
        Item4ArrowsGray,

        /// <remarks/>
        [XmlEnum("4RedToBlack")]
        Item4RedToBlack,

        /// <remarks/>
        [XmlEnum("4Rating")]
        Item4Rating,

        /// <remarks/>
        [XmlEnum("4TrafficLights")]
        Item4TrafficLights,

        /// <remarks/>
        [XmlEnum("5Arrows")]
        Item5Arrows,

        /// <remarks/>
        [XmlEnum("5ArrowsGray")]
        Item5ArrowsGray,

        /// <remarks/>
        [XmlEnum("5Rating")]
        Item5Rating,

        /// <remarks/>
        [XmlEnum("5Quarters")]
        Item5Quarters,
    }

    public class CT_Top10
    {

        private bool topField;

        private bool percentField;

        private double valField;

        private double filterValField;

        private bool filterValFieldSpecified;

        public CT_Top10()
        {
            this.topField = true;
            this.percentField = false;
        }

        [DefaultValue(true)]
        public bool top
        {
            get
            {
                return this.topField;
            }
            set
            {
                this.topField = value;
            }
        }

        [DefaultValue(false)]
        public bool percent
        {
            get
            {
                return this.percentField;
            }
            set
            {
                this.percentField = value;
            }
        }

        public double val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }

        public double filterVal
        {
            get
            {
                return this.filterValField;
            }
            set
            {
                this.filterValField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnore]
        public bool filterValSpecified
        {
            get
            {
                return this.filterValFieldSpecified;
            }
            set
            {
                this.filterValFieldSpecified = value;
            }
        }
    }

    public class CT_SortState
    {

        private List<CT_SortCondition> sortConditionField;

        private CT_ExtensionList extLstField;

        private bool columnSortField;

        private bool caseSensitiveField;

        private ST_SortMethod sortMethodField;

        private string refField;

        public CT_SortState()
        {
            this.extLstField = new CT_ExtensionList();
            this.sortConditionField = new List<CT_SortCondition>();
            this.columnSortField = false;
            this.caseSensitiveField = false;
            this.sortMethodField = ST_SortMethod.none;
        }

        public List<CT_SortCondition> sortCondition
        {
            get
            {
                return this.sortConditionField;
            }
            set
            {
                this.sortConditionField = value;
            }
        }

        public CT_ExtensionList extLst
        {
            get
            {
                return this.extLstField;
            }
            set
            {
                this.extLstField = value;
            }
        }

        [DefaultValue(false)]
        public bool columnSort
        {
            get
            {
                return this.columnSortField;
            }
            set
            {
                this.columnSortField = value;
            }
        }

        [DefaultValue(false)]
        public bool caseSensitive
        {
            get
            {
                return this.caseSensitiveField;
            }
            set
            {
                this.caseSensitiveField = value;
            }
        }

        [DefaultValue(ST_SortMethod.none)]
        public ST_SortMethod sortMethod
        {
            get
            {
                return this.sortMethodField;
            }
            set
            {
                this.sortMethodField = value;
            }
        }

        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    public class CT_SortCondition
    {

        private bool descendingField;

        private ST_SortBy sortByField;

        private string refField;

        private string customListField;

        private uint dxfIdField;

        private bool dxfIdFieldSpecified;

        private ST_IconSetType iconSetField;

        private uint iconIdField;

        private bool iconIdFieldSpecified;

        public CT_SortCondition()
        {
            this.descendingField = false;
            this.sortByField = ST_SortBy.value;
            this.iconSetField = ST_IconSetType.Item3Arrows;
        }

        [DefaultValue(false)]
        public bool descending
        {
            get
            {
                return this.descendingField;
            }
            set
            {
                this.descendingField = value;
            }
        }

        [DefaultValue(ST_SortBy.value)]
        public ST_SortBy sortBy
        {
            get
            {
                return this.sortByField;
            }
            set
            {
                this.sortByField = value;
            }
        }

        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }

        public string customList
        {
            get
            {
                return this.customListField;
            }
            set
            {
                this.customListField = value;
            }
        }

        public uint dxfId
        {
            get
            {
                return this.dxfIdField;
            }
            set
            {
                this.dxfIdField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnore]
        public bool dxfIdSpecified
        {
            get
            {
                return this.dxfIdFieldSpecified;
            }
            set
            {
                this.dxfIdFieldSpecified = value;
            }
        }

        [DefaultValue(ST_IconSetType.Item3Arrows)]
        public ST_IconSetType iconSet
        {
            get
            {
                return this.iconSetField;
            }
            set
            {
                this.iconSetField = value;
            }
        }

        public uint iconId
        {
            get
            {
                return this.iconIdField;
            }
            set
            {
                this.iconIdField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnore]
        public bool iconIdSpecified
        {
            get
            {
                return this.iconIdFieldSpecified;
            }
            set
            {
                this.iconIdFieldSpecified = value;
            }
        }
    }

    public enum ST_SortBy
    {

        /// <remarks/>
        value,

        /// <remarks/>
        cellColor,

        /// <remarks/>
        fontColor,

        /// <remarks/>
        icon,
    }

    public enum ST_SortMethod
    {

        /// <remarks/>
        stroke,

        /// <remarks/>
        pinYin,

        /// <remarks/>
        none,
    }
}
