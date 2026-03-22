//HintName: G.Models.EPromptOptimizationAlgorithm.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EPromptOptimizationAlgorithm
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="demo")]
        Demo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="promptim")]
        Promptim,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EPromptOptimizationAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EPromptOptimizationAlgorithm value)
        {
            return value switch
            {
                EPromptOptimizationAlgorithm.Demo => "demo",
                EPromptOptimizationAlgorithm.Promptim => "promptim",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EPromptOptimizationAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "demo" => EPromptOptimizationAlgorithm.Demo,
                "promptim" => EPromptOptimizationAlgorithm.Promptim,
                _ => null,
            };
        }
    }
}