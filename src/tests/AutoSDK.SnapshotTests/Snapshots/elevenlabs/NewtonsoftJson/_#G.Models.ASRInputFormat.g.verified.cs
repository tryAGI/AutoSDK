//HintName: G.Models.ASRInputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ASRInputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_8000")]
        Pcm8000,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_16000")]
        Pcm16000,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_22050")]
        Pcm22050,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_24000")]
        Pcm24000,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_44100")]
        Pcm44100,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_48000")]
        Pcm48000,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ulaw_8000")]
        Ulaw8000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ASRInputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASRInputFormat value)
        {
            return value switch
            {
                ASRInputFormat.Pcm8000 => "pcm_8000",
                ASRInputFormat.Pcm16000 => "pcm_16000",
                ASRInputFormat.Pcm22050 => "pcm_22050",
                ASRInputFormat.Pcm24000 => "pcm_24000",
                ASRInputFormat.Pcm44100 => "pcm_44100",
                ASRInputFormat.Pcm48000 => "pcm_48000",
                ASRInputFormat.Ulaw8000 => "ulaw_8000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASRInputFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm_8000" => ASRInputFormat.Pcm8000,
                "pcm_16000" => ASRInputFormat.Pcm16000,
                "pcm_22050" => ASRInputFormat.Pcm22050,
                "pcm_24000" => ASRInputFormat.Pcm24000,
                "pcm_44100" => ASRInputFormat.Pcm44100,
                "pcm_48000" => ASRInputFormat.Pcm48000,
                "ulaw_8000" => ASRInputFormat.Ulaw8000,
                _ => null,
            };
        }
    }
}