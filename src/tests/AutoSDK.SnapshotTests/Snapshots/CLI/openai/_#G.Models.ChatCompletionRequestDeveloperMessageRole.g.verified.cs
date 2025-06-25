//HintName: G.Models.ChatCompletionRequestDeveloperMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the messages author, in this case `developer`.
    /// </summary>
    public enum ChatCompletionRequestDeveloperMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestDeveloperMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestDeveloperMessageRole value)
        {
            return value switch
            {
                ChatCompletionRequestDeveloperMessageRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestDeveloperMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "developer" => ChatCompletionRequestDeveloperMessageRole.Developer,
                _ => null,
            };
        }
    }
}