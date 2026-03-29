//HintName: G.Models.FallbackSpeechmaticsTranscriberOperatingPoint.g.cs

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
    public enum FallbackSpeechmaticsTranscriberOperatingPoint
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
    public static class FallbackSpeechmaticsTranscriberOperatingPointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackSpeechmaticsTranscriberOperatingPoint value)
        {
            return value switch
            {
                FallbackSpeechmaticsTranscriberOperatingPoint.Enhanced => "enhanced",
                FallbackSpeechmaticsTranscriberOperatingPoint.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackSpeechmaticsTranscriberOperatingPoint? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => FallbackSpeechmaticsTranscriberOperatingPoint.Enhanced,
                "standard" => FallbackSpeechmaticsTranscriberOperatingPoint.Standard,
                _ => null,
            };
        }
    }
}