//HintName: G.Models.FineTuneSupervisedHyperparametersLearningRateMultiplier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuneSupervisedHyperparametersLearningRateMultiplier
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneSupervisedHyperparametersLearningRateMultiplierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneSupervisedHyperparametersLearningRateMultiplier value)
        {
            return value switch
            {
                FineTuneSupervisedHyperparametersLearningRateMultiplier.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneSupervisedHyperparametersLearningRateMultiplier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FineTuneSupervisedHyperparametersLearningRateMultiplier.Auto,
                _ => null,
            };
        }
    }
}