//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        ExitLoop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3Type value)
        {
            return value switch
            {
                TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3Type.ExitLoop => "exit_loop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "exit_loop" => TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3Type.ExitLoop,
                _ => null,
            };
        }
    }
}