//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevel
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevel value)
        {
            return value switch
            {
                TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevel.High => "high",
                TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevel.Low => "low",
                TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevel.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevel? ToEnum(string value)
        {
            return value switch
            {
                "high" => TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevel.High,
                "low" => TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevel.Low,
                "medium" => TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevel.Medium,
                _ => null,
            };
        }
    }
}