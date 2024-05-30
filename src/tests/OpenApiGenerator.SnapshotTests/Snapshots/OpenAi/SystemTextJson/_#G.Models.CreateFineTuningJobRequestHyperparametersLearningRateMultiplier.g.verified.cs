//HintName: G.Models.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFineTuningJobRequestHyperparametersLearningRateMultiplier
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    public static class CreateFineTuningJobRequestHyperparametersLearningRateMultiplierExtensions
    {
        public static string ToValueString(this CreateFineTuningJobRequestHyperparametersLearningRateMultiplier value)
        {
            return value switch
            {
                CreateFineTuningJobRequestHyperparametersLearningRateMultiplier.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateFineTuningJobRequestHyperparametersLearningRateMultiplier ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateFineTuningJobRequestHyperparametersLearningRateMultiplier.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateFineTuningJobRequestHyperparametersLearningRateMultiplier ToEnum(int value)
        {
            return value switch
            {
                0 => CreateFineTuningJobRequestHyperparametersLearningRateMultiplier.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}