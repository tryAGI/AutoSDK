//HintName: G.Models.ChatCompletionMessageParamFallbackRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionMessageParamFallbackRole
    {
        /// <summary>
        /// 
        /// </summary>
        Model,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionMessageParamFallbackRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionMessageParamFallbackRole value)
        {
            return value switch
            {
                ChatCompletionMessageParamFallbackRole.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionMessageParamFallbackRole? ToEnum(string value)
        {
            return value switch
            {
                "model" => ChatCompletionMessageParamFallbackRole.Model,
                _ => null,
            };
        }
    }
}