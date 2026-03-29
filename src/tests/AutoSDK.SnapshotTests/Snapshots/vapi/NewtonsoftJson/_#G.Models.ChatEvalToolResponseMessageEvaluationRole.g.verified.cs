//HintName: G.Models.ChatEvalToolResponseMessageEvaluationRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the role of the message author.<br/>
    /// For a tool response message evaluation, the role is always 'tool'<br/>
    /// @default 'tool'<br/>
    /// Default Value: tool
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatEvalToolResponseMessageEvaluationRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatEvalToolResponseMessageEvaluationRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatEvalToolResponseMessageEvaluationRole value)
        {
            return value switch
            {
                ChatEvalToolResponseMessageEvaluationRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatEvalToolResponseMessageEvaluationRole? ToEnum(string value)
        {
            return value switch
            {
                "tool" => ChatEvalToolResponseMessageEvaluationRole.Tool,
                _ => null,
            };
        }
    }
}