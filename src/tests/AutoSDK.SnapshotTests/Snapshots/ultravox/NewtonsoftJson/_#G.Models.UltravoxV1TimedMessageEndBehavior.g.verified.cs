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
        [global::System.Runtime.Serialization.EnumMember(Value="END_BEHAVIOR_HANG_UP_SOFT")]
        EndBehaviorHangUpSoft,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="END_BEHAVIOR_HANG_UP_STRICT")]
        EndBehaviorHangUpStrict,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="END_BEHAVIOR_UNSPECIFIED")]
        EndBehaviorUnspecified,
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
                UltravoxV1TimedMessageEndBehavior.EndBehaviorHangUpSoft => "END_BEHAVIOR_HANG_UP_SOFT",
                UltravoxV1TimedMessageEndBehavior.EndBehaviorHangUpStrict => "END_BEHAVIOR_HANG_UP_STRICT",
                UltravoxV1TimedMessageEndBehavior.EndBehaviorUnspecified => "END_BEHAVIOR_UNSPECIFIED",
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
                "END_BEHAVIOR_HANG_UP_SOFT" => UltravoxV1TimedMessageEndBehavior.EndBehaviorHangUpSoft,
                "END_BEHAVIOR_HANG_UP_STRICT" => UltravoxV1TimedMessageEndBehavior.EndBehaviorHangUpStrict,
                "END_BEHAVIOR_UNSPECIFIED" => UltravoxV1TimedMessageEndBehavior.EndBehaviorUnspecified,
                _ => null,
            };
        }
    }
}