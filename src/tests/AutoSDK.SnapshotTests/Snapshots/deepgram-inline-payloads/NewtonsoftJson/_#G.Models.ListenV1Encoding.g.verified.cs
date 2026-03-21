//HintName: G.Models.ListenV1Encoding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Encoding format of the submitted audio.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListenV1Encoding
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="linear16")]
        Linear16,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flac")]
        Flac,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mulaw")]
        Mulaw,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="amr-nb")]
        AmrNb,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="amr-wb")]
        AmrWb,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="opus")]
        Opus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="speex")]
        Speex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1EncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1Encoding value)
        {
            return value switch
            {
                ListenV1Encoding.Linear16 => "linear16",
                ListenV1Encoding.Flac => "flac",
                ListenV1Encoding.Mulaw => "mulaw",
                ListenV1Encoding.AmrNb => "amr-nb",
                ListenV1Encoding.AmrWb => "amr-wb",
                ListenV1Encoding.Opus => "opus",
                ListenV1Encoding.Speex => "speex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1Encoding? ToEnum(string value)
        {
            return value switch
            {
                "linear16" => ListenV1Encoding.Linear16,
                "flac" => ListenV1Encoding.Flac,
                "mulaw" => ListenV1Encoding.Mulaw,
                "amr-nb" => ListenV1Encoding.AmrNb,
                "amr-wb" => ListenV1Encoding.AmrWb,
                "opus" => ListenV1Encoding.Opus,
                "speex" => ListenV1Encoding.Speex,
                _ => null,
            };
        }
    }
}