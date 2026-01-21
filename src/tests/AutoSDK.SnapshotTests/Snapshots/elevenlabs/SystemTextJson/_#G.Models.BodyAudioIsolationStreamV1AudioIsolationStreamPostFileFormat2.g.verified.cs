//HintName: G.Models.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2
    {
        /// <summary>
        /// 
        /// </summary>
        PcmS16le16,
        /// <summary>
        /// 
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2 value)
        {
            return value switch
            {
                BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2.PcmS16le16 => "pcm_s16le_16",
                BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2? ToEnum(string value)
        {
            return value switch
            {
                "pcm_s16le_16" => BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2.PcmS16le16,
                "other" => BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2.Other,
                _ => null,
            };
        }
    }
}