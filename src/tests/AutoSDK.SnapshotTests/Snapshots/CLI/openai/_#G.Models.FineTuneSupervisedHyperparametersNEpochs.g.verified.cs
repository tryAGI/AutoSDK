//HintName: G.Models.FineTuneSupervisedHyperparametersNEpochs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuneSupervisedHyperparametersNEpochs
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneSupervisedHyperparametersNEpochsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneSupervisedHyperparametersNEpochs value)
        {
            return value switch
            {
                FineTuneSupervisedHyperparametersNEpochs.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneSupervisedHyperparametersNEpochs? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FineTuneSupervisedHyperparametersNEpochs.Auto,
                _ => null,
            };
        }
    }
}