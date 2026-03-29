//HintName: G.Models.FileCitationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the file citation. Always `file_citation`.
    /// </summary>
    public enum FileCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        FileCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileCitationType value)
        {
            return value switch
            {
                FileCitationType.FileCitation => "file_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileCitationType? ToEnum(string value)
        {
            return value switch
            {
                "file_citation" => FileCitationType.FileCitation,
                _ => null,
            };
        }
    }
}