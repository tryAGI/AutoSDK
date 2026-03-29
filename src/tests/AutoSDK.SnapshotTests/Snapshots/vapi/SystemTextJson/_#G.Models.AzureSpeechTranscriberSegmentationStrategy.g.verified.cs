//HintName: G.Models.AzureSpeechTranscriberSegmentationStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls how phrase boundaries are detected, enabling either simple time/silence heuristics or more advanced semantic segmentation.
    /// </summary>
    public enum AzureSpeechTranscriberSegmentationStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Semantic,
        /// <summary>
        /// 
        /// </summary>
        Time,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzureSpeechTranscriberSegmentationStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureSpeechTranscriberSegmentationStrategy value)
        {
            return value switch
            {
                AzureSpeechTranscriberSegmentationStrategy.Default => "Default",
                AzureSpeechTranscriberSegmentationStrategy.Semantic => "Semantic",
                AzureSpeechTranscriberSegmentationStrategy.Time => "Time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureSpeechTranscriberSegmentationStrategy? ToEnum(string value)
        {
            return value switch
            {
                "Default" => AzureSpeechTranscriberSegmentationStrategy.Default,
                "Semantic" => AzureSpeechTranscriberSegmentationStrategy.Semantic,
                "Time" => AzureSpeechTranscriberSegmentationStrategy.Time,
                _ => null,
            };
        }
    }
}