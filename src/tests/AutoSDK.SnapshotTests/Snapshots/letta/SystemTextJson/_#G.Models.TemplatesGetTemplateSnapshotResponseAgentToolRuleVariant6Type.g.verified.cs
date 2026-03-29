//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        RequiredBeforeExit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6Type value)
        {
            return value switch
            {
                TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6Type.RequiredBeforeExit => "required_before_exit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "required_before_exit" => TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6Type.RequiredBeforeExit,
                _ => null,
            };
        }
    }
}