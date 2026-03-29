//HintName: G.Models.PictureClassificationLabel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// PictureClassificationLabel.
    /// </summary>
    public enum PictureClassificationLabel
    {
        /// <summary>
        /// 
        /// </summary>
        BarChart,
        /// <summary>
        /// 
        /// </summary>
        BarCode,
        /// <summary>
        /// 
        /// </summary>
        BoxPlot,
        /// <summary>
        /// 
        /// </summary>
        CadDrawing,
        /// <summary>
        /// 
        /// </summary>
        Calendar,
        /// <summary>
        /// 
        /// </summary>
        ChemistryMarkushStructure,
        /// <summary>
        /// 
        /// </summary>
        ChemistryMolecularStructure,
        /// <summary>
        /// 
        /// </summary>
        ChemistryStructure,
        /// <summary>
        /// 
        /// </summary>
        CrosswordPuzzle,
        /// <summary>
        /// 
        /// </summary>
        ElectricalDiagram,
        /// <summary>
        /// 
        /// </summary>
        EngineeringDrawing,
        /// <summary>
        /// 
        /// </summary>
        FlowChart,
        /// <summary>
        /// 
        /// </summary>
        FullPageImage,
        /// <summary>
        /// 
        /// </summary>
        GeographicalMap,
        /// <summary>
        /// 
        /// </summary>
        Heatmap,
        /// <summary>
        /// 
        /// </summary>
        Icon,
        /// <summary>
        /// 
        /// </summary>
        LineChart,
        /// <summary>
        /// 
        /// </summary>
        Logo,
        /// <summary>
        /// 
        /// </summary>
        Map,
        /// <summary>
        /// 
        /// </summary>
        Music,
        /// <summary>
        /// 
        /// </summary>
        NaturalImage,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        PageThumbnail,
        /// <summary>
        /// 
        /// </summary>
        Photograph,
        /// <summary>
        /// 
        /// </summary>
        PictureGroup,
        /// <summary>
        /// 
        /// </summary>
        PieChart,
        /// <summary>
        /// 
        /// </summary>
        QrCode,
        /// <summary>
        /// 
        /// </summary>
        RemoteSensing,
        /// <summary>
        /// 
        /// </summary>
        ScatterChart,
        /// <summary>
        /// 
        /// </summary>
        ScatterPlot,
        /// <summary>
        /// 
        /// </summary>
        Screenshot,
        /// <summary>
        /// 
        /// </summary>
        ScreenshotFromComputer,
        /// <summary>
        /// 
        /// </summary>
        ScreenshotFromManual,
        /// <summary>
        /// 
        /// </summary>
        Signature,
        /// <summary>
        /// 
        /// </summary>
        StackedBarChart,
        /// <summary>
        /// 
        /// </summary>
        Stamp,
        /// <summary>
        /// 
        /// </summary>
        StratigraphicChart,
        /// <summary>
        /// 
        /// </summary>
        Table,
        /// <summary>
        /// 
        /// </summary>
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