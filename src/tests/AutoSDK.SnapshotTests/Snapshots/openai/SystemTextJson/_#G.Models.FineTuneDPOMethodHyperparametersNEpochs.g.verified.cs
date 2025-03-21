//HintName: G.Models.FineTuneDPOMethodHyperparametersNEpochs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuneDPOMethodHyperparametersNEpochs
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneDPOMethodHyperparametersNEpochsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneDPOMethodHyperparametersNEpochs value)
        {
            return value switch
            {
                FineTuneDPOMethodHyperparametersNEpochs.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneDPOMethodHyperparametersNEpochs? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FineTuneDPOMethodHyperparametersNEpochs.Auto,
                _ => null,
            };
        }
    }
}