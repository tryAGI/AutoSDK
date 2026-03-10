//HintName: G.Models.VoiceResponseModelSafetyControl2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoiceResponseModelSafetyControl2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BAN")]
        Ban,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CAPTCHA")]
        Captcha,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ENTERPRISE_BAN")]
        EnterpriseBan,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ENTERPRISE_CAPTCHA")]
        EnterpriseCaptcha,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceResponseModelSafetyControl2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceResponseModelSafetyControl2 value)
        {
            return value switch
            {
                VoiceResponseModelSafetyControl2.None => "NONE",
                VoiceResponseModelSafetyControl2.Ban => "BAN",
                VoiceResponseModelSafetyControl2.Captcha => "CAPTCHA",
                VoiceResponseModelSafetyControl2.EnterpriseBan => "ENTERPRISE_BAN",
                VoiceResponseModelSafetyControl2.EnterpriseCaptcha => "ENTERPRISE_CAPTCHA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceResponseModelSafetyControl2? ToEnum(string value)
        {
            return value switch
            {
                "NONE" => VoiceResponseModelSafetyControl2.None,
                "BAN" => VoiceResponseModelSafetyControl2.Ban,
                "CAPTCHA" => VoiceResponseModelSafetyControl2.Captcha,
                "ENTERPRISE_BAN" => VoiceResponseModelSafetyControl2.EnterpriseBan,
                "ENTERPRISE_CAPTCHA" => VoiceResponseModelSafetyControl2.EnterpriseCaptcha,
                _ => null,
            };
        }
    }
}