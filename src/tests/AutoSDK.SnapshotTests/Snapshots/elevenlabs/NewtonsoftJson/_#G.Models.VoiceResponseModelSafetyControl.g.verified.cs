//HintName: G.Models.VoiceResponseModelSafetyControl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoiceResponseModelSafetyControl
    {
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceResponseModelSafetyControlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceResponseModelSafetyControl value)
        {
            return value switch
            {
                VoiceResponseModelSafetyControl.Ban => "BAN",
                VoiceResponseModelSafetyControl.Captcha => "CAPTCHA",
                VoiceResponseModelSafetyControl.EnterpriseBan => "ENTERPRISE_BAN",
                VoiceResponseModelSafetyControl.EnterpriseCaptcha => "ENTERPRISE_CAPTCHA",
                VoiceResponseModelSafetyControl.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceResponseModelSafetyControl? ToEnum(string value)
        {
            return value switch
            {
                "BAN" => VoiceResponseModelSafetyControl.Ban,
                "CAPTCHA" => VoiceResponseModelSafetyControl.Captcha,
                "ENTERPRISE_BAN" => VoiceResponseModelSafetyControl.EnterpriseBan,
                "ENTERPRISE_CAPTCHA" => VoiceResponseModelSafetyControl.EnterpriseCaptcha,
                "NONE" => VoiceResponseModelSafetyControl.None,
                _ => null,
            };
        }
    }
}