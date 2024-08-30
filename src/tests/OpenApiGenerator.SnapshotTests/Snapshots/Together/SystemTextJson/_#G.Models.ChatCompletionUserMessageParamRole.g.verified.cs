//HintName: G.Models.ChatCompletionUserMessageParamRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionUserMessageParamRole
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionUserMessageParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionUserMessageParamRole value)
        {
            return value switch
            {
                ChatCompletionUserMessageParamRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionUserMessageParamRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => ChatCompletionUserMessageParamRole.User,
                _ => null,
            };
        }
    }
}