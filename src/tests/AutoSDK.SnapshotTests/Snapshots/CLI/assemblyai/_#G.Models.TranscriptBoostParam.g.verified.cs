//HintName: G.Models.TranscriptBoostParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How much to boost specified words
    /// </summary>
    public enum TranscriptBoostParam
    {
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptBoostParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptBoostParam value)
        {
            return value switch
            {
                TranscriptBoostParam.Low => "low",
                TranscriptBoostParam.Default => "default",
                TranscriptBoostParam.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptBoostParam? ToEnum(string value)
        {
            return value switch
            {
                "low" => TranscriptBoostParam.Low,
                "default" => TranscriptBoostParam.Default,
                "high" => TranscriptBoostParam.High,
                _ => null,
            };
        }
    }
}