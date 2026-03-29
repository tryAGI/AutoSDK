//HintName: G.Models.PictureClassificationLabel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// PictureClassificationLabel.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PictureClassificationLabel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bar_chart")]
        BarChart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bar_code")]
        BarCode,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="box_plot")]
        BoxPlot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cad_drawing")]
        CadDrawing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="calendar")]
        Calendar,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chemistry_markush_structure")]
        ChemistryMarkushStructure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chemistry_molecular_structure")]
        ChemistryMolecularStructure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chemistry_structure")]
        ChemistryStructure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="crossword_puzzle")]
        CrosswordPuzzle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="electrical_diagram")]
        ElectricalDiagram,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="engineering_drawing")]
        EngineeringDrawing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flow_chart")]
        FlowChart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="full_page_image")]
        FullPageImage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="geographical_map")]
        GeographicalMap,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="heatmap")]
        Heatmap,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="icon")]
        Icon,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="line_chart")]
        LineChart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="logo")]
        Logo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="map")]
        Map,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="music")]
        Music,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="natural_image")]
        NaturalImage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="other")]
        Other,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="page_thumbnail")]
        PageThumbnail,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="photograph")]
        Photograph,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="picture_group")]
        PictureGroup,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pie_chart")]
        PieChart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="qr_code")]
        QrCode,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="remote_sensing")]
        RemoteSensing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scatter_chart")]
        ScatterChart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scatter_plot")]
        ScatterPlot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="screenshot")]
        Screenshot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="screenshot_from_computer")]
        ScreenshotFromComputer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="screenshot_from_manual")]
        ScreenshotFromManual,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="signature")]
        Signature,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stacked_bar_chart")]
        StackedBarChart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stamp")]
        Stamp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stratigraphic_chart")]
        StratigraphicChart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="table")]
        Table,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="topographical_map")]
        TopographicalMap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PictureClassificationLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PictureClassificationLabel value)
        {
            return value switch
            {
                PictureClassificationLabel.BarChart => "bar_chart",
                PictureClassificationLabel.BarCode => "bar_code",
                PictureClassificationLabel.BoxPlot => "box_plot",
                PictureClassificationLabel.CadDrawing => "cad_drawing",
                PictureClassificationLabel.Calendar => "calendar",
                PictureClassificationLabel.ChemistryMarkushStructure => "chemistry_markush_structure",
                PictureClassificationLabel.ChemistryMolecularStructure => "chemistry_molecular_structure",
                PictureClassificationLabel.ChemistryStructure => "chemistry_structure",
                PictureClassificationLabel.CrosswordPuzzle => "crossword_puzzle",
                PictureClassificationLabel.ElectricalDiagram => "electrical_diagram",
                PictureClassificationLabel.EngineeringDrawing => "engineering_drawing",
                PictureClassificationLabel.FlowChart => "flow_chart",
                PictureClassificationLabel.FullPageImage => "full_page_image",
                PictureClassificationLabel.GeographicalMap => "geographical_map",
                PictureClassificationLabel.Heatmap => "heatmap",
                PictureClassificationLabel.Icon => "icon",
                PictureClassificationLabel.LineChart => "line_chart",
                PictureClassificationLabel.Logo => "logo",
                PictureClassificationLabel.Map => "map",
                PictureClassificationLabel.Music => "music",
                PictureClassificationLabel.NaturalImage => "natural_image",
                PictureClassificationLabel.Other => "other",
                PictureClassificationLabel.PageThumbnail => "page_thumbnail",
                PictureClassificationLabel.Photograph => "photograph",
                PictureClassificationLabel.PictureGroup => "picture_group",
                PictureClassificationLabel.PieChart => "pie_chart",
                PictureClassificationLabel.QrCode => "qr_code",
                PictureClassificationLabel.RemoteSensing => "remote_sensing",
                PictureClassificationLabel.ScatterChart => "scatter_chart",
                PictureClassificationLabel.ScatterPlot => "scatter_plot",
                PictureClassificationLabel.Screenshot => "screenshot",
                PictureClassificationLabel.ScreenshotFromComputer => "screenshot_from_computer",
                PictureClassificationLabel.ScreenshotFromManual => "screenshot_from_manual",
                PictureClassificationLabel.Signature => "signature",
                PictureClassificationLabel.StackedBarChart => "stacked_bar_chart",
                PictureClassificationLabel.Stamp => "stamp",
                PictureClassificationLabel.StratigraphicChart => "stratigraphic_chart",
                PictureClassificationLabel.Table => "table",
                PictureClassificationLabel.TopographicalMap => "topographical_map",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PictureClassificationLabel? ToEnum(string value)
        {
            return value switch
            {
                "bar_chart" => PictureClassificationLabel.BarChart,
                "bar_code" => PictureClassificationLabel.BarCode,
                "box_plot" => PictureClassificationLabel.BoxPlot,
                "cad_drawing" => PictureClassificationLabel.CadDrawing,
                "calendar" => PictureClassificationLabel.Calendar,
                "chemistry_markush_structure" => PictureClassificationLabel.ChemistryMarkushStructure,
                "chemistry_molecular_structure" => PictureClassificationLabel.ChemistryMolecularStructure,
                "chemistry_structure" => PictureClassificationLabel.ChemistryStructure,
                "crossword_puzzle" => PictureClassificationLabel.CrosswordPuzzle,
                "electrical_diagram" => PictureClassificationLabel.ElectricalDiagram,
                "engineering_drawing" => PictureClassificationLabel.EngineeringDrawing,
                "flow_chart" => PictureClassificationLabel.FlowChart,
                "full_page_image" => PictureClassificationLabel.FullPageImage,
                "geographical_map" => PictureClassificationLabel.GeographicalMap,
                "heatmap" => PictureClassificationLabel.Heatmap,
                "icon" => PictureClassificationLabel.Icon,
                "line_chart" => PictureClassificationLabel.LineChart,
                "logo" => PictureClassificationLabel.Logo,
                "map" => PictureClassificationLabel.Map,
                "music" => PictureClassificationLabel.Music,
                "natural_image" => PictureClassificationLabel.NaturalImage,
                "other" => PictureClassificationLabel.Other,
                "page_thumbnail" => PictureClassificationLabel.PageThumbnail,
                "photograph" => PictureClassificationLabel.Photograph,
                "picture_group" => PictureClassificationLabel.PictureGroup,
                "pie_chart" => PictureClassificationLabel.PieChart,
                "qr_code" => PictureClassificationLabel.QrCode,
                "remote_sensing" => PictureClassificationLabel.RemoteSensing,
                "scatter_chart" => PictureClassificationLabel.ScatterChart,
                "scatter_plot" => PictureClassificationLabel.ScatterPlot,
                "screenshot" => PictureClassificationLabel.Screenshot,
                "screenshot_from_computer" => PictureClassificationLabel.ScreenshotFromComputer,
                "screenshot_from_manual" => PictureClassificationLabel.ScreenshotFromManual,
                "signature" => PictureClassificationLabel.Signature,
                "stacked_bar_chart" => PictureClassificationLabel.StackedBarChart,
                "stamp" => PictureClassificationLabel.Stamp,
                "stratigraphic_chart" => PictureClassificationLabel.StratigraphicChart,
                "table" => PictureClassificationLabel.Table,
                "topographical_map" => PictureClassificationLabel.TopographicalMap,
                _ => null,
            };
        }
    }
}