//HintName: G.Models.FallbackAzureSpeechTranscriberSegmentationStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls how phrase boundaries are detected, enabling either simple time/silence heuristics or more advanced semantic segmentation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackAzureSpeechTranscriberSegmentationStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Semantic")]
        Semantic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Time")]
        Time,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackAzureSpeechTranscriberSegmentationStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackAzureSpeechTranscriberSegmentationStrategy value)
        {
            return value switch
            {
                FallbackAzureSpeechTranscriberSegmentationStrategy.Default => "Default",
                FallbackAzureSpeechTranscriberSegmentationStrategy.Semantic => "Semantic",
                FallbackAzureSpeechTranscriberSegmentationStrategy.Time => "Time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackAzureSpeechTranscriberSegmentationStrategy? ToEnum(string value)
        {
            return value switch
            {
                "Default" => FallbackAzureSpeechTranscriberSegmentationStrategy.Default,
                "Semantic" => FallbackAzureSpeechTranscriberSegmentationStrategy.Semantic,
                "Time" => FallbackAzureSpeechTranscriberSegmentationStrategy.Time,
                _ => null,
            };
        }
    }
}