//HintName: G.Models.FineTuningJobHyperparametersNEpochs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuningJobHyperparametersNEpochs
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    public static class FineTuningJobHyperparametersNEpochsExtensions
    {
        public static string ToValueString(this FineTuningJobHyperparametersNEpochs value)
        {
            return value switch
            {
                FineTuningJobHyperparametersNEpochs.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static FineTuningJobHyperparametersNEpochs ToEnum(string value)
        {
            return value switch
            {
                "auto" => FineTuningJobHyperparametersNEpochs.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static FineTuningJobHyperparametersNEpochs ToEnum(int value)
        {
            return value switch
            {
                0 => FineTuningJobHyperparametersNEpochs.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}