//HintName: G.Models.IKnowledgeMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Role is used to mark from whom is the message<br/>
    /// assistant mean from agent<br/>
    /// user means from user
    /// </summary>
    public enum IKnowledgeMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IKnowledgeMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IKnowledgeMessageRole value)
        {
            return value switch
            {
                IKnowledgeMessageRole.Assistant => "assistant",
                IKnowledgeMessageRole.Function => "function",
                IKnowledgeMessageRole.System => "system",
                IKnowledgeMessageRole.Tool => "tool",
                IKnowledgeMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IKnowledgeMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => IKnowledgeMessageRole.Assistant,
                "function" => IKnowledgeMessageRole.Function,
                "system" => IKnowledgeMessageRole.System,
                "tool" => IKnowledgeMessageRole.Tool,
                "user" => IKnowledgeMessageRole.User,
                _ => null,
            };
        }
    }
}