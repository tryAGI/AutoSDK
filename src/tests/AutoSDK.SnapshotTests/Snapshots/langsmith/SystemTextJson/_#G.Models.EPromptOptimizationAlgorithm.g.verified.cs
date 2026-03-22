//HintName: G.Models.EPromptOptimizationAlgorithm.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EPromptOptimizationAlgorithm
    {
        /// <summary>
        /// 
        /// </summary>
        Demo,
        /// <summary>
        /// 
        /// </summary>
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