//HintName: G.Models.CreateResponseRequestReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Level of reasoning effort. Supported values: `low`, `medium`, `high`. Lower values provide faster responses with less reasoning depth.<br/>
    /// Default Value: medium
    /// </summary>
    public enum CreateResponseRequestReasoningEffort
    {
        /// <summary>
        /// `low`, `medium`, `high`. Lower values provide faster responses with less reasoning depth.
        /// </summary>
        High,
        /// <summary>
        /// `low`, `medium`, `high`. Lower values provide faster responses with less reasoning depth.
        /// </summary>
        Low,
        /// <summary>
        /// `low`, `medium`, `high`. Lower values provide faster responses with less reasoning depth.
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResponseRequestReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseRequestReasoningEffort value)
        {
            return value switch
            {
                CreateResponseRequestReasoningEffort.High => "high",
                CreateResponseRequestReasoningEffort.Low => "low",
                CreateResponseRequestReasoningEffort.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseRequestReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateResponseRequestReasoningEffort.High,
                "low" => CreateResponseRequestReasoningEffort.Low,
                "medium" => CreateResponseRequestReasoningEffort.Medium,
                _ => null,
            };
        }
    }
}