//HintName: G.Models.CreateSearchRequestIncludeRawContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSearchRequestIncludeRawContent
    {
        /// <summary>
        /// 
        /// </summary>
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSearchRequestIncludeRawContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSearchRequestIncludeRawContent value)
        {
            return value switch
            {
                CreateSearchRequestIncludeRawContent.Markdown => "markdown",
                CreateSearchRequestIncludeRawContent.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSearchRequestIncludeRawContent? ToEnum(string value)
        {
            return value switch
            {
                "markdown" => CreateSearchRequestIncludeRawContent.Markdown,
                "text" => CreateSearchRequestIncludeRawContent.Text,
                _ => null,
            };
        }
    }
}