//HintName: G.Models.BodyAudioIsolationV1AudioIsolationPostFileFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyAudioIsolationV1AudioIsolationPostFileFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="other")]
        Other,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_s16le_16")]
        PcmS16le16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyAudioIsolationV1AudioIsolationPostFileFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyAudioIsolationV1AudioIsolationPostFileFormat value)
        {
            return value switch
            {
                BodyAudioIsolationV1AudioIsolationPostFileFormat.Other => "other",
                BodyAudioIsolationV1AudioIsolationPostFileFormat.PcmS16le16 => "pcm_s16le_16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyAudioIsolationV1AudioIsolationPostFileFormat? ToEnum(string value)
        {
            return value switch
            {
                "other" => BodyAudioIsolationV1AudioIsolationPostFileFormat.Other,
                "pcm_s16le_16" => BodyAudioIsolationV1AudioIsolationPostFileFormat.PcmS16le16,
                _ => null,
            };
        }
    }
}