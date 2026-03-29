//HintName: G.Models.ReturnFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Format options for the returned document content.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReturnFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="html")]
        Html,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="markdown")]
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="plain")]
        Plain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReturnFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReturnFormat value)
        {
            return value switch
            {
                ReturnFormat.Html => "html",
                ReturnFormat.Markdown => "markdown",
                ReturnFormat.Plain => "plain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReturnFormat? ToEnum(string value)
        {
            return value switch
            {
                "html" => ReturnFormat.Html,
                "markdown" => ReturnFormat.Markdown,
                "plain" => ReturnFormat.Plain,
                _ => null,
            };
        }
    }
}