//HintName: G.Models.TagHandlingOption.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sets which kind of tags should be handled. Options currently available:<br/>
    ///  * `xml`: Enable XML tag handling; see [XML Handling](https://www.deepl.com/docs-api/xml).<br/>
    ///  * `html`: Enable HTML tag handling; see [HTML Handling](https://www.deepl.com/docs-api/html).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TagHandlingOption
    {
        /// <summary>
        /// Enable HTML tag handling; see [HTML Handling](https://www.deepl.com/docs-api/html).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="html")]
        Html,
        /// <summary>
        /// Enable XML tag handling; see [XML Handling](https://www.deepl.com/docs-api/xml).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="xml")]
        Xml,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TagHandlingOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TagHandlingOption value)
        {
            return value switch
            {
                TagHandlingOption.Html => "html",
                TagHandlingOption.Xml => "xml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TagHandlingOption? ToEnum(string value)
        {
            return value switch
            {
                "html" => TagHandlingOption.Html,
                "xml" => TagHandlingOption.Xml,
                _ => null,
            };
        }
    }
}