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
        Promptim,
        /// <summary>
        /// 
        /// </summary>
        Demo,
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
                EPromptOptimizationAlgorithm.Promptim => "promptim",
                EPromptOptimizationAlgorithm.Demo => "demo",
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
                "promptim" => EPromptOptimizationAlgorithm.Promptim,
                "demo" => EPromptOptimizationAlgorithm.Demo,
                _ => null,
            };
        }
    }
}