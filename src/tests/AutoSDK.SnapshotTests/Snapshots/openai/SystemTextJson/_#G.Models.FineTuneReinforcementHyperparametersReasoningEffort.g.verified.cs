//HintName: G.Models.FineTuneReinforcementHyperparametersReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Level of reasoning effort.<br/>
    /// Default Value: default
    /// </summary>
    public enum FineTuneReinforcementHyperparametersReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneReinforcementHyperparametersReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneReinforcementHyperparametersReasoningEffort value)
        {
            return value switch
            {
                FineTuneReinforcementHyperparametersReasoningEffort.Default => "default",
                FineTuneReinforcementHyperparametersReasoningEffort.Low => "low",
                FineTuneReinforcementHyperparametersReasoningEffort.Medium => "medium",
                FineTuneReinforcementHyperparametersReasoningEffort.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneReinforcementHyperparametersReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "default" => FineTuneReinforcementHyperparametersReasoningEffort.Default,
                "low" => FineTuneReinforcementHyperparametersReasoningEffort.Low,
                "medium" => FineTuneReinforcementHyperparametersReasoningEffort.Medium,
                "high" => FineTuneReinforcementHyperparametersReasoningEffort.High,
                _ => null,
            };
        }
    }
}