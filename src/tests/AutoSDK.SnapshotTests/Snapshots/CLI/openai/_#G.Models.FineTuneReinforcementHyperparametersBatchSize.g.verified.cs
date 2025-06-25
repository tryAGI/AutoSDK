//HintName: G.Models.FineTuneReinforcementHyperparametersBatchSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuneReinforcementHyperparametersBatchSize
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneReinforcementHyperparametersBatchSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneReinforcementHyperparametersBatchSize value)
        {
            return value switch
            {
                FineTuneReinforcementHyperparametersBatchSize.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneReinforcementHyperparametersBatchSize? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FineTuneReinforcementHyperparametersBatchSize.Auto,
                _ => null,
            };
        }
    }
}