//HintName: G.Models.BodyAudioIsolationV1AudioIsolationPostFileFormat2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyAudioIsolationV1AudioIsolationPostFileFormat2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_s16le_16")]
        PcmS16le16,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="other")]
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyAudioIsolationV1AudioIsolationPostFileFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyAudioIsolationV1AudioIsolationPostFileFormat2 value)
        {
            return value switch
            {
                BodyAudioIsolationV1AudioIsolationPostFileFormat2.PcmS16le16 => "pcm_s16le_16",
                BodyAudioIsolationV1AudioIsolationPostFileFormat2.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyAudioIsolationV1AudioIsolationPostFileFormat2? ToEnum(string value)
        {
            return value switch
            {
                "pcm_s16le_16" => BodyAudioIsolationV1AudioIsolationPostFileFormat2.PcmS16le16,
                "other" => BodyAudioIsolationV1AudioIsolationPostFileFormat2.Other,
                _ => null,
            };
        }
    }
}