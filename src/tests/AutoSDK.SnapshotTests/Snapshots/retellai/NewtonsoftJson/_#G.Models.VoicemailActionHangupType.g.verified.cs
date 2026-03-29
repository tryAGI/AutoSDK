//HintName: G.Models.VoicemailActionHangupType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: hangup
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoicemailActionHangupType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hangup")]
        Hangup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoicemailActionHangupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicemailActionHangupType value)
        {
            return value switch
            {
                VoicemailActionHangupType.Hangup => "hangup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicemailActionHangupType? ToEnum(string value)
        {
            return value switch
            {
                "hangup" => VoicemailActionHangupType.Hangup,
                _ => null,
            };
        }
    }
}