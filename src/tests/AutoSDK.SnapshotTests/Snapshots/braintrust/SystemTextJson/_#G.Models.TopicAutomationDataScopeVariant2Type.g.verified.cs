//HintName: G.Models.TopicAutomationDataScopeVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TopicAutomationDataScopeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectExperiments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopicAutomationDataScopeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicAutomationDataScopeVariant2Type value)
        {
            return value switch
            {
                TopicAutomationDataScopeVariant2Type.ProjectExperiments => "project_experiments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicAutomationDataScopeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "project_experiments" => TopicAutomationDataScopeVariant2Type.ProjectExperiments,
                _ => null,
            };
        }
    }
}