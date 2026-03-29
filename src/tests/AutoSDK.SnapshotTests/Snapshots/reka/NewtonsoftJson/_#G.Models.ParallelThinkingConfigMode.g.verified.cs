//HintName: G.Models.ParallelThinkingConfigMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Computational intensity level. "none" is standard, "low" moderate, "high" maximum quality.<br/>
    /// Default Value: none
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ParallelThinkingConfigMode
    {
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParallelThinkingConfigModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParallelThinkingConfigMode value)
        {
            return value switch
            {
                ParallelThinkingConfigMode.High => "high",
                ParallelThinkingConfigMode.Low => "low",
                ParallelThinkingConfigMode.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParallelThinkingConfigMode? ToEnum(string value)
        {
            return value switch
            {
                "high" => ParallelThinkingConfigMode.High,
                "low" => ParallelThinkingConfigMode.Low,
                "none" => ParallelThinkingConfigMode.None,
                _ => null,
            };
        }
    }
}