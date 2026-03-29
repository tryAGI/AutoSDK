//HintName: G.Models.VoicemailToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "voicemail" for Voicemail tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoicemailToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voicemail")]
        Voicemail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoicemailToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicemailToolType value)
        {
            return value switch
            {
                VoicemailToolType.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicemailToolType? ToEnum(string value)
        {
            return value switch
            {
                "voicemail" => VoicemailToolType.Voicemail,
                _ => null,
            };
        }
    }
}