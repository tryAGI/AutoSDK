//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="continue_loop")]
        ContinueLoop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5Type value)
        {
            return value switch
            {
                TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5Type.ContinueLoop => "continue_loop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "continue_loop" => TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5Type.ContinueLoop,
                _ => null,
            };
        }
    }
}