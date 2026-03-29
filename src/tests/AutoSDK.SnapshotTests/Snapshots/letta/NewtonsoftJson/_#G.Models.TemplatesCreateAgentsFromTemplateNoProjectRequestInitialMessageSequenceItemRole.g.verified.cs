//HintName: G.Models.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
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