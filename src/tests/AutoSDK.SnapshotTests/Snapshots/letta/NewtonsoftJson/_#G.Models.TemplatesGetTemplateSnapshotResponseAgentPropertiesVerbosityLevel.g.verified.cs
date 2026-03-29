//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
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