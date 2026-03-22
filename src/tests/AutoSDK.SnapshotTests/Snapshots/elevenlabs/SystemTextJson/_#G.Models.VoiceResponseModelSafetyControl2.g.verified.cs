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
        Ban,
        /// <summary>
        /// 
        /// </summary>
        Captcha,
        /// <summary>
        /// 
        /// </summary>
        EnterpriseBan,
        /// <summary>
        /// 
        /// </summary>
        EnterpriseCaptcha,
        /// <summary>
        /// 
        /// </summary>
        None,
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
                VoiceResponseModelSafetyControl2.Ban => "BAN",
                VoiceResponseModelSafetyControl2.Captcha => "CAPTCHA",
                VoiceResponseModelSafetyControl2.EnterpriseBan => "ENTERPRISE_BAN",
                VoiceResponseModelSafetyControl2.EnterpriseCaptcha => "ENTERPRISE_CAPTCHA",
                VoiceResponseModelSafetyControl2.None => "NONE",
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
                "BAN" => VoiceResponseModelSafetyControl2.Ban,
                "CAPTCHA" => VoiceResponseModelSafetyControl2.Captcha,
                "ENTERPRISE_BAN" => VoiceResponseModelSafetyControl2.EnterpriseBan,
                "ENTERPRISE_CAPTCHA" => VoiceResponseModelSafetyControl2.EnterpriseCaptcha,
                "NONE" => VoiceResponseModelSafetyControl2.None,
                _ => null,
            };
        }
    }
}