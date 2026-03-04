//HintName: G.Models.ApiTokenState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State describes the state of an API token.<br/>
    ///  - STATE_INACTIVE: Inactive.<br/>
    ///  - STATE_ACTIVE: Active.<br/>
    ///  - STATE_EXPIRED: Expired.
    /// </summary>
    public enum ApiTokenState
    {
        /// <summary>
        /// Inactive.
        /// </summary>
        StateInactive,
        /// <summary>
        /// Active.
        /// </summary>
        StateActive,
        /// <summary>
        /// Expired.
        /// </summary>
        StateExpired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiTokenStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiTokenState value)
        {
            return value switch
            {
                ApiTokenState.StateInactive => "STATE_INACTIVE",
                ApiTokenState.StateActive => "STATE_ACTIVE",
                ApiTokenState.StateExpired => "STATE_EXPIRED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiTokenState? ToEnum(string value)
        {
            return value switch
            {
                "STATE_INACTIVE" => ApiTokenState.StateInactive,
                "STATE_ACTIVE" => ApiTokenState.StateActive,
                "STATE_EXPIRED" => ApiTokenState.StateExpired,
                _ => null,
            };
        }
    }
}