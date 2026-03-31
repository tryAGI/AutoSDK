//HintName: G.Models.TopicAutomationDataScopeVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TopicAutomationDataScopeVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectLogs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopicAutomationDataScopeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicAutomationDataScopeVariant1Type value)
        {
            return value switch
            {
                TopicAutomationDataScopeVariant1Type.ProjectLogs => "project_logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicAutomationDataScopeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "project_logs" => TopicAutomationDataScopeVariant1Type.ProjectLogs,
                _ => null,
            };
        }
    }
}