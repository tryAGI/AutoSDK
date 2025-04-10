//HintName: G.Models.UltravoxV1TimedMessageEndBehavior.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The behavior to exhibit when the message is finished being spoken.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UltravoxV1TimedMessageEndBehavior
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="END_BEHAVIOR_UNSPECIFIED")]
        ENDBEHAVIORUNSPECIFIED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="END_BEHAVIOR_HANG_UP_SOFT")]
        ENDBEHAVIORHANGUPSOFT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="END_BEHAVIOR_HANG_UP_STRICT")]
        ENDBEHAVIORHANGUPSTRICT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1TimedMessageEndBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1TimedMessageEndBehavior value)
        {
            return value switch
            {
                UltravoxV1TimedMessageEndBehavior.ENDBEHAVIORUNSPECIFIED => "END_BEHAVIOR_UNSPECIFIED",
                UltravoxV1TimedMessageEndBehavior.ENDBEHAVIORHANGUPSOFT => "END_BEHAVIOR_HANG_UP_SOFT",
                UltravoxV1TimedMessageEndBehavior.ENDBEHAVIORHANGUPSTRICT => "END_BEHAVIOR_HANG_UP_STRICT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1TimedMessageEndBehavior? ToEnum(string value)
        {
            return value switch
            {
                "END_BEHAVIOR_UNSPECIFIED" => UltravoxV1TimedMessageEndBehavior.ENDBEHAVIORUNSPECIFIED,
                "END_BEHAVIOR_HANG_UP_SOFT" => UltravoxV1TimedMessageEndBehavior.ENDBEHAVIORHANGUPSOFT,
                "END_BEHAVIOR_HANG_UP_STRICT" => UltravoxV1TimedMessageEndBehavior.ENDBEHAVIORHANGUPSTRICT,
                _ => null,
            };
        }
    }
}