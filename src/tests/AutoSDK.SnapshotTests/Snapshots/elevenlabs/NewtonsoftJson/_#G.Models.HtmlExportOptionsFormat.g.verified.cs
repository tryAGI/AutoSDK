//HintName: G.Models.HtmlExportOptionsFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HtmlExportOptionsFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="html")]
        Html,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HtmlExportOptionsFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HtmlExportOptionsFormat value)
        {
            return value switch
            {
                HtmlExportOptionsFormat.Html => "html",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HtmlExportOptionsFormat? ToEnum(string value)
        {
            return value switch
            {
                "html" => HtmlExportOptionsFormat.Html,
                _ => null,
            };
        }
    }
}