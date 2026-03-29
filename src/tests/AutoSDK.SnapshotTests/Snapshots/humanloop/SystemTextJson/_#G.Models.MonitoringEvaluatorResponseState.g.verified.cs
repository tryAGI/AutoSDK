//HintName: G.Models.MonitoringEvaluatorResponseState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the monitoring evaluator.
    /// </summary>
    public enum MonitoringEvaluatorResponseState
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MonitoringEvaluatorResponseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MonitoringEvaluatorResponseState value)
        {
            return value switch
            {
                MonitoringEvaluatorResponseState.Active => "active",
                MonitoringEvaluatorResponseState.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MonitoringEvaluatorResponseState? ToEnum(string value)
        {
            return value switch
            {
                "active" => MonitoringEvaluatorResponseState.Active,
                "inactive" => MonitoringEvaluatorResponseState.Inactive,
                _ => null,
            };
        }
    }
}