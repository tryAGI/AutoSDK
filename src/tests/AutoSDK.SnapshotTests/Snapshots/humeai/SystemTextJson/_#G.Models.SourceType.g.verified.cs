//HintName: G.Models.SourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SourceType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SourceType value)
        {
            return value switch
            {
                SourceType.File => "file",
                SourceType.Text => "text",
                SourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SourceType? ToEnum(string value)
        {
            return value switch
            {
                "file" => SourceType.File,
                "text" => SourceType.Text,
                "url" => SourceType.Url,
                _ => null,
            };
        }
    }
}