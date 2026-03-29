//HintName: G.Models.ResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deepseekocr_markdown")]
        DeepseekocrMarkdown,
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
        [global::System.Runtime.Serialization.EnumMember(Value="markdown")]
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="otsl")]
        Otsl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="plaintext")]
        Plaintext,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormat value)
        {
            return value switch
            {
                ResponseFormat.DeepseekocrMarkdown => "deepseekocr_markdown",
                ResponseFormat.Doctags => "doctags",
                ResponseFormat.Html => "html",
                ResponseFormat.Markdown => "markdown",
                ResponseFormat.Otsl => "otsl",
                ResponseFormat.Plaintext => "plaintext",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "deepseekocr_markdown" => ResponseFormat.DeepseekocrMarkdown,
                "doctags" => ResponseFormat.Doctags,
                "html" => ResponseFormat.Html,
                "markdown" => ResponseFormat.Markdown,
                "otsl" => ResponseFormat.Otsl,
                "plaintext" => ResponseFormat.Plaintext,
                _ => null,
            };
        }
    }
}