//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Conditional,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4Type value)
        {
            return value switch
            {
                TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4Type.Conditional => "conditional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "conditional" => TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4Type.Conditional,
                _ => null,
            };
        }
    }
}