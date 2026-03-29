//HintName: G.Models.SpeechmaticsTranscriberOperatingPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the operating point for the transcription. Choose between `standard` for faster turnaround with strong accuracy or `enhanced` for highest accuracy when precision is critical.<br/>
    /// @default 'enhanced'<br/>
    /// Default Value: enhanced<br/>
    /// Example: enhanced
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpeechmaticsTranscriberOperatingPoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enhanced")]
        Enhanced,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="standard")]
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechmaticsTranscriberOperatingPointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechmaticsTranscriberOperatingPoint value)
        {
            return value switch
            {
                SpeechmaticsTranscriberOperatingPoint.Enhanced => "enhanced",
                SpeechmaticsTranscriberOperatingPoint.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechmaticsTranscriberOperatingPoint? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => SpeechmaticsTranscriberOperatingPoint.Enhanced,
                "standard" => SpeechmaticsTranscriberOperatingPoint.Standard,
                _ => null,
            };
        }
    }
}