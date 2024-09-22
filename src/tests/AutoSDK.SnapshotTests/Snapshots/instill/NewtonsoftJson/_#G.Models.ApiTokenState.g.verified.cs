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
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiTokenState
    {
        /// <summary>
        /// Inactive.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATE_INACTIVE")]
        STATEINACTIVE,
        /// <summary>
        /// Active.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATE_ACTIVE")]
        STATEACTIVE,
        /// <summary>
        /// Expired.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATE_EXPIRED")]
        STATEEXPIRED,
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
                ApiTokenState.STATEINACTIVE => "STATE_INACTIVE",
                ApiTokenState.STATEACTIVE => "STATE_ACTIVE",
                ApiTokenState.STATEEXPIRED => "STATE_EXPIRED",
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
                "STATE_INACTIVE" => ApiTokenState.STATEINACTIVE,
                "STATE_ACTIVE" => ApiTokenState.STATEACTIVE,
                "STATE_EXPIRED" => ApiTokenState.STATEEXPIRED,
                _ => null,
            };
        }
    }
}