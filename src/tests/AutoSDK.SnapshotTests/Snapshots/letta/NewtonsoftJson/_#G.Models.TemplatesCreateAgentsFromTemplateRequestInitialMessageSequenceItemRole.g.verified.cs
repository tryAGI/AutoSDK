//HintName: G.Models.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole
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
    public static class TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole value)
        {
            return value switch
            {
                TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole.Assistant => "assistant",
                TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole.System => "system",
                TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole.Assistant,
                "system" => TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole.System,
                "user" => TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole.User,
                _ => null,
            };
        }
    }
}