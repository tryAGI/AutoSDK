//HintName: G.Models.DocumentState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output only. Current state of the `Document`.<br/>
    /// Included only in responses
    /// </summary>
    public enum DocumentState
    {
        /// <summary>
        /// All `Chunks` of the `Document` is processed and available for querying.
        /// </summary>
        StateActive,
        /// <summary>
        /// Some `Chunks` of the `Document` failed processing.
        /// </summary>
        StateFailed,
        /// <summary>
        /// Some `Chunks` of the `Document` are being processed (embedding and vector storage).
        /// </summary>
        StatePending,
        /// <summary>
        /// The default value. This value is used if the state is omitted.
        /// </summary>
        StateUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentState value)
        {
            return value switch
            {
                DocumentState.StateActive => "STATE_ACTIVE",
                DocumentState.StateFailed => "STATE_FAILED",
                DocumentState.StatePending => "STATE_PENDING",
                DocumentState.StateUnspecified => "STATE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentState? ToEnum(string value)
        {
            return value switch
            {
                "STATE_ACTIVE" => DocumentState.StateActive,
                "STATE_FAILED" => DocumentState.StateFailed,
                "STATE_PENDING" => DocumentState.StatePending,
                "STATE_UNSPECIFIED" => DocumentState.StateUnspecified,
                _ => null,
            };
        }
    }
}