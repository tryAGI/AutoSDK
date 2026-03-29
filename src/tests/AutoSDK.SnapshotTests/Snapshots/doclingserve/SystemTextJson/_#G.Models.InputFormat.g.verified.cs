//HintName: G.Models.InputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A document format supported by document backend parsers.
    /// </summary>
    public enum InputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Asciidoc,
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Csv,
        /// <summary>
        /// 
        /// </summary>
        Docx,
        /// <summary>
        /// 
        /// </summary>
        Html,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        JsonDocling,
        /// <summary>
        /// 
        /// </summary>
        Latex,
        /// <summary>
        /// 
        /// </summary>
        Md,
        /// <summary>
        /// 
        /// </summary>
        MetsGbs,
        /// <summary>
        /// 
        /// </summary>
        Pdf,
        /// <summary>
        /// 
        /// </summary>
        Pptx,
        /// <summary>
        /// 
        /// </summary>
        Vtt,
        /// <summary>
        /// 
        /// </summary>
        Xlsx,
        /// <summary>
        /// 
        /// </summary>
        XmlJats,
        /// <summary>
        /// 
        /// </summary>
        XmlUspto,
        /// <summary>
        /// 
        /// </summary>
        XmlXbrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputFormat value)
        {
            return value switch
            {
                InputFormat.Asciidoc => "asciidoc",
                InputFormat.Audio => "audio",
                InputFormat.Csv => "csv",
                InputFormat.Docx => "docx",
                InputFormat.Html => "html",
                InputFormat.Image => "image",
                InputFormat.JsonDocling => "json_docling",
                InputFormat.Latex => "latex",
                InputFormat.Md => "md",
                InputFormat.MetsGbs => "mets_gbs",
                InputFormat.Pdf => "pdf",
                InputFormat.Pptx => "pptx",
                InputFormat.Vtt => "vtt",
                InputFormat.Xlsx => "xlsx",
                InputFormat.XmlJats => "xml_jats",
                InputFormat.XmlUspto => "xml_uspto",
                InputFormat.XmlXbrl => "xml_xbrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputFormat? ToEnum(string value)
        {
            return value switch
            {
                "asciidoc" => InputFormat.Asciidoc,
                "audio" => InputFormat.Audio,
                "csv" => InputFormat.Csv,
                "docx" => InputFormat.Docx,
                "html" => InputFormat.Html,
                "image" => InputFormat.Image,
                "json_docling" => InputFormat.JsonDocling,
                "latex" => InputFormat.Latex,
                "md" => InputFormat.Md,
                "mets_gbs" => InputFormat.MetsGbs,
                "pdf" => InputFormat.Pdf,
                "pptx" => InputFormat.Pptx,
                "vtt" => InputFormat.Vtt,
                "xlsx" => InputFormat.Xlsx,
                "xml_jats" => InputFormat.XmlJats,
                "xml_uspto" => InputFormat.XmlUspto,
                "xml_xbrl" => InputFormat.XmlXbrl,
                _ => null,
            };
        }
    }
}