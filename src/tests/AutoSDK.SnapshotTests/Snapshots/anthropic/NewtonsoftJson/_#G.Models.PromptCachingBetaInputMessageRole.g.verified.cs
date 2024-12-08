//HintName: G.Models.PromptCachingBetaInputMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptCachingBetaInputMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCachingBetaInputMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCachingBetaInputMessageRole value)
        {
            return value switch
            {
                PromptCachingBetaInputMessageRole.User => "user",
                PromptCachingBetaInputMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCachingBetaInputMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => PromptCachingBetaInputMessageRole.User,
                "assistant" => PromptCachingBetaInputMessageRole.Assistant,
                _ => null,
            };
        }
    }
}