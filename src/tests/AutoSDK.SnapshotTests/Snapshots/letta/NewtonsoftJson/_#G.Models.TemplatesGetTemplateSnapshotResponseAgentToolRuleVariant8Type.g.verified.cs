//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parent_last_tool")]
        ParentLastTool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8Type value)
        {
            return value switch
            {
                TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8Type.ParentLastTool => "parent_last_tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "parent_last_tool" => TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8Type.ParentLastTool,
                _ => null,
            };
        }
    }
}