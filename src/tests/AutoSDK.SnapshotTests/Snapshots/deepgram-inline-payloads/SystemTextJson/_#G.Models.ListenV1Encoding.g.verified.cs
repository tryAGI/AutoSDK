//HintName: G.Models.ListenV1Encoding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Encoding format of the submitted audio.
    /// </summary>
    public enum ListenV1Encoding
    {
        /// <summary>
        /// 
        /// </summary>
        AmrNb,
        /// <summary>
        /// 
        /// </summary>
        AmrWb,
        /// <summary>
        /// 
        /// </summary>
        Flac,
        /// <summary>
        /// 
        /// </summary>
        Linear16,
        /// <summary>
        /// 
        /// </summary>
        Mulaw,
        /// <summary>
        /// 
        /// </summary>
        Opus,
        /// <summary>
        /// 
        /// </summary>
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
                ListenV1Encoding.AmrNb => "amr-nb",
                ListenV1Encoding.AmrWb => "amr-wb",
                ListenV1Encoding.Flac => "flac",
                ListenV1Encoding.Linear16 => "linear16",
                ListenV1Encoding.Mulaw => "mulaw",
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
                "amr-nb" => ListenV1Encoding.AmrNb,
                "amr-wb" => ListenV1Encoding.AmrWb,
                "flac" => ListenV1Encoding.Flac,
                "linear16" => ListenV1Encoding.Linear16,
                "mulaw" => ListenV1Encoding.Mulaw,
                "opus" => ListenV1Encoding.Opus,
                "speex" => ListenV1Encoding.Speex,
                _ => null,
            };
        }
    }
}