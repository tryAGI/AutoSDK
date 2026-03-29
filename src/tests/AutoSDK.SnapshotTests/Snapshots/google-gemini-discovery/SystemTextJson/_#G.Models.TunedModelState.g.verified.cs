//HintName: G.Models.TunedModelState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output only. The state of the tuned model.<br/>
    /// Included only in responses
    /// </summary>
    public enum TunedModelState
    {
        /// <summary>
        /// The model is ready to be used.
        /// </summary>
        Active,
        /// <summary>
        /// The model is being created.
        /// </summary>
        Creating,
        /// <summary>
        /// The model failed to be created.
        /// </summary>
        Failed,
        /// <summary>
        /// The default value. This value is unused.
        /// </summary>
        StateUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TunedModelStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TunedModelState value)
        {
            return value switch
            {
                TunedModelState.Active => "ACTIVE",
                TunedModelState.Creating => "CREATING",
                TunedModelState.Failed => "FAILED",
                TunedModelState.StateUnspecified => "STATE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TunedModelState? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => TunedModelState.Active,
                "CREATING" => TunedModelState.Creating,
                "FAILED" => TunedModelState.Failed,
                "STATE_UNSPECIFIED" => TunedModelState.StateUnspecified,
                _ => null,
            };
        }
    }
}