//HintName: G.Models.PublishedProjectConflictErrorState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current state of the published project<br/>
    /// Example: processing
    /// </summary>
    public enum PublishedProjectConflictErrorState
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishedProjectConflictErrorStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishedProjectConflictErrorState value)
        {
            return value switch
            {
                PublishedProjectConflictErrorState.Failed => "failed",
                PublishedProjectConflictErrorState.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishedProjectConflictErrorState? ToEnum(string value)
        {
            return value switch
            {
                "failed" => PublishedProjectConflictErrorState.Failed,
                "processing" => PublishedProjectConflictErrorState.Processing,
                _ => null,
            };
        }
    }
}