//HintName: G.Models.FineTuneSupervisedMethodHyperparametersLearningRateMultiplier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FineTuneSupervisedMethodHyperparametersLearningRateMultiplier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneSupervisedMethodHyperparametersLearningRateMultiplierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneSupervisedMethodHyperparametersLearningRateMultiplier value)
        {
            return value switch
            {
                FineTuneSupervisedMethodHyperparametersLearningRateMultiplier.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneSupervisedMethodHyperparametersLearningRateMultiplier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FineTuneSupervisedMethodHyperparametersLearningRateMultiplier.Auto,
                _ => null,
            };
        }
    }
}