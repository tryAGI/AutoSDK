//HintName: G.Models.FineTuneReinforcementHyperparametersEvalSamples.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuneReinforcementHyperparametersEvalSamples
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneReinforcementHyperparametersEvalSamplesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneReinforcementHyperparametersEvalSamples value)
        {
            return value switch
            {
                FineTuneReinforcementHyperparametersEvalSamples.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneReinforcementHyperparametersEvalSamples? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FineTuneReinforcementHyperparametersEvalSamples.Auto,
                _ => null,
            };
        }
    }
}