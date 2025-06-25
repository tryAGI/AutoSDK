//HintName: G.Models.FileCitationBodyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the file citation. Always `file_citation`.<br/>
    /// Default Value: file_citation
    /// </summary>
    public enum FileCitationBodyType
    {
        /// <summary>
        /// 
        /// </summary>
        FileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileCitationBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileCitationBodyType value)
        {
            return value switch
            {
                FileCitationBodyType.FileCitation => "file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileCitationBodyType? ToEnum(string value)
        {
            return value switch
            {
                "file_citation" => FileCitationBodyType.FileCitation,
                _ => null,
            };
        }
    }
}