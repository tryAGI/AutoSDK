//HintName: G.Models.OutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="doctags")]
        Doctags,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="html")]
        Html,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="html_split_page")]
        HtmlSplitPage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json")]
        Json,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="md")]
        Md,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vtt")]
        Vtt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="yaml")]
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