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
        NONE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BAN")]
        BAN,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CAPTCHA")]
        CAPTCHA,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CAPTCHA_AND_MODERATION")]
        CAPTCHAANDMODERATION,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ENTERPRISE_BAN")]
        ENTERPRISEBAN,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ENTERPRISE_CAPTCHA")]
        ENTERPRISECAPTCHA,
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
                VoiceResponseModelSafetyControl2.NONE => "NONE",
                VoiceResponseModelSafetyControl2.BAN => "BAN",
                VoiceResponseModelSafetyControl2.CAPTCHA => "CAPTCHA",
                VoiceResponseModelSafetyControl2.CAPTCHAANDMODERATION => "CAPTCHA_AND_MODERATION",
                VoiceResponseModelSafetyControl2.ENTERPRISEBAN => "ENTERPRISE_BAN",
                VoiceResponseModelSafetyControl2.ENTERPRISECAPTCHA => "ENTERPRISE_CAPTCHA",
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
                "NONE" => VoiceResponseModelSafetyControl2.NONE,
                "BAN" => VoiceResponseModelSafetyControl2.BAN,
                "CAPTCHA" => VoiceResponseModelSafetyControl2.CAPTCHA,
                "CAPTCHA_AND_MODERATION" => VoiceResponseModelSafetyControl2.CAPTCHAANDMODERATION,
                "ENTERPRISE_BAN" => VoiceResponseModelSafetyControl2.ENTERPRISEBAN,
                "ENTERPRISE_CAPTCHA" => VoiceResponseModelSafetyControl2.ENTERPRISECAPTCHA,
                _ => null,
            };
        }
    }
}