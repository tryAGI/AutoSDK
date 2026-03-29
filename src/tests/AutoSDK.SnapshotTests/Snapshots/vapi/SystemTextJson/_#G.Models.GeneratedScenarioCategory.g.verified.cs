//HintName: G.Models.GeneratedScenarioCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Scenario category
    /// </summary>
    public enum GeneratedScenarioCategory
    {
        /// <summary>
        /// 
        /// </summary>
        EdgeCase,
        /// <summary>
        /// 
        /// </summary>
        FailureMode,
        /// <summary>
        /// 
        /// </summary>
        HappyPath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneratedScenarioCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratedScenarioCategory value)
        {
            return value switch
            {
                GeneratedScenarioCategory.EdgeCase => "edge_case",
                GeneratedScenarioCategory.FailureMode => "failure_mode",
                GeneratedScenarioCategory.HappyPath => "happy_path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratedScenarioCategory? ToEnum(string value)
        {
            return value switch
            {
                "edge_case" => GeneratedScenarioCategory.EdgeCase,
                "failure_mode" => GeneratedScenarioCategory.FailureMode,
                "happy_path" => GeneratedScenarioCategory.HappyPath,
                _ => null,
            };
        }
    }
}