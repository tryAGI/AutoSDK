//HintName: G.Models.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        PcmS16le16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat value)
        {
            return value switch
            {
                BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat.Other => "other",
                BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat.PcmS16le16 => "pcm_s16le_16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat? ToEnum(string value)
        {
            return value switch
            {
                "other" => BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat.Other,
                "pcm_s16le_16" => BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat.PcmS16le16,
                _ => null,
            };
        }
    }
}