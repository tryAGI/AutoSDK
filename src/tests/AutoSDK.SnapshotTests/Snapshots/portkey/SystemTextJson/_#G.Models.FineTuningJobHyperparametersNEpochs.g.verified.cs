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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuningJobHyperparametersNEpochsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuningJobHyperparametersNEpochs value)
        {
            return value switch
            {
                FineTuningJobHyperparametersNEpochs.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuningJobHyperparametersNEpochs? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FineTuningJobHyperparametersNEpochs.Auto,
                _ => null,
            };
        }
    }
}