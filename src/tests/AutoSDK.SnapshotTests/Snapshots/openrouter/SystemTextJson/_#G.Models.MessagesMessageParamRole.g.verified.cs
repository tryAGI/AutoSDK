//HintName: G.Models.MessagesMessageParamRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesMessageParamRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamRole value)
        {
            return value switch
            {
                MessagesMessageParamRole.Assistant => "assistant",
                MessagesMessageParamRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => MessagesMessageParamRole.Assistant,
                "user" => MessagesMessageParamRole.User,
                _ => null,
            };
        }
    }
}