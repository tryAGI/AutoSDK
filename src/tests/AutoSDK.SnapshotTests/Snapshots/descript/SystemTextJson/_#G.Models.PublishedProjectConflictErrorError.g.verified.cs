//HintName: G.Models.PublishedProjectConflictErrorError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error type identifier<br/>
    /// Example: conflict
    /// </summary>
    public enum PublishedProjectConflictErrorError
    {
        /// <summary>
        /// 
        /// </summary>
        Conflict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishedProjectConflictErrorErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishedProjectConflictErrorError value)
        {
            return value switch
            {
                PublishedProjectConflictErrorError.Conflict => "conflict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishedProjectConflictErrorError? ToEnum(string value)
        {
            return value switch
            {
                "conflict" => PublishedProjectConflictErrorError.Conflict,
                _ => null,
            };
        }
    }
}