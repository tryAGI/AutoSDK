//HintName: G.Models.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole value)
        {
            return value switch
            {
                TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole.Assistant => "assistant",
                TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole.System => "system",
                TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole.Assistant,
                "system" => TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole.System,
                "user" => TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole.User,
                _ => null,
            };
        }
    }
}