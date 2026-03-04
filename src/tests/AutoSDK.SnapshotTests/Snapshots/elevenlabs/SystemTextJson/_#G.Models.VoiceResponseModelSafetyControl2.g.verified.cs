//HintName: G.Models.VoiceResponseModelSafetyControl2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceResponseModelSafetyControl2
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Ban,
        /// <summary>
        /// 
        /// </summary>
        Captcha,
        /// <summary>
        /// 
        /// </summary>
        CaptchaAndModeration,
        /// <summary>
        /// 
        /// </summary>
        EnterpriseBan,
        /// <summary>
        /// 
        /// </summary>
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
                VoiceResponseModelSafetyControl2.CaptchaAndModeration => "CAPTCHA_AND_MODERATION",
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
                "CAPTCHA_AND_MODERATION" => VoiceResponseModelSafetyControl2.CaptchaAndModeration,
                "ENTERPRISE_BAN" => VoiceResponseModelSafetyControl2.EnterpriseBan,
                "ENTERPRISE_CAPTCHA" => VoiceResponseModelSafetyControl2.EnterpriseCaptcha,
                _ => null,
            };
        }
    }
}