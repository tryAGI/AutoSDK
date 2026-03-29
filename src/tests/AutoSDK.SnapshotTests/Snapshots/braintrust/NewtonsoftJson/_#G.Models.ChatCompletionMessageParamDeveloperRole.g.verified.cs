//HintName: G.Models.ChatCompletionMessageParamDeveloperRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionMessageParamDeveloperRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="developer")]
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionMessageParamDeveloperRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionMessageParamDeveloperRole value)
        {
            return value switch
            {
                ChatCompletionMessageParamDeveloperRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionMessageParamDeveloperRole? ToEnum(string value)
        {
            return value switch
            {
                "developer" => ChatCompletionMessageParamDeveloperRole.Developer,
                _ => null,
            };
        }
    }
}