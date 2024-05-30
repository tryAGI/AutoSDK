//HintName: G.Models.CreateFineTuningJobRequestHyperparametersNEpochs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFineTuningJobRequestHyperparametersNEpochs
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    public static class CreateFineTuningJobRequestHyperparametersNEpochsExtensions
    {
        public static string ToValueString(this CreateFineTuningJobRequestHyperparametersNEpochs value)
        {
            return value switch
            {
                CreateFineTuningJobRequestHyperparametersNEpochs.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateFineTuningJobRequestHyperparametersNEpochs ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateFineTuningJobRequestHyperparametersNEpochs.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateFineTuningJobRequestHyperparametersNEpochs ToEnum(int value)
        {
            return value switch
            {
                0 => CreateFineTuningJobRequestHyperparametersNEpochs.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}