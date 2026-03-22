//HintName: G.Models.TranscriptBoostParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How much to boost specified words
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranscriptBoostParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
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
                TranscriptBoostParam.Default => "default",
                TranscriptBoostParam.High => "high",
                TranscriptBoostParam.Low => "low",
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
                "default" => TranscriptBoostParam.Default,
                "high" => TranscriptBoostParam.High,
                "low" => TranscriptBoostParam.Low,
                _ => null,
            };
        }
    }
}