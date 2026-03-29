//HintName: G.Models.OutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Doctags,
        /// <summary>
        /// 
        /// </summary>
        Html,
        /// <summary>
        /// 
        /// </summary>
        HtmlSplitPage,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Md,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Vtt,
        /// <summary>
        /// 
        /// </summary>
        Yaml,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputFormat value)
        {
            return value switch
            {
                OutputFormat.Doctags => "doctags",
                OutputFormat.Html => "html",
                OutputFormat.HtmlSplitPage => "html_split_page",
                OutputFormat.Json => "json",
                OutputFormat.Md => "md",
                OutputFormat.Text => "text",
                OutputFormat.Vtt => "vtt",
                OutputFormat.Yaml => "yaml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "doctags" => OutputFormat.Doctags,
                "html" => OutputFormat.Html,
                "html_split_page" => OutputFormat.HtmlSplitPage,
                "json" => OutputFormat.Json,
                "md" => OutputFormat.Md,
                "text" => OutputFormat.Text,
                "vtt" => OutputFormat.Vtt,
                "yaml" => OutputFormat.Yaml,
                _ => null,
            };
        }
    }
}