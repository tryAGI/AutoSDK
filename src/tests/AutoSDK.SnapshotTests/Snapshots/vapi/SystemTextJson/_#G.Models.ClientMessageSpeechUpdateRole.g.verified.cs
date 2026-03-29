//HintName: G.Models.ClientMessageSpeechUpdateRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the role which the speech update is for.
    /// </summary>
    public enum ClientMessageSpeechUpdateRole
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
    public static class ClientMessageSpeechUpdateRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageSpeechUpdateRole value)
        {
            return value switch
            {
                ClientMessageSpeechUpdateRole.Assistant => "assistant",
                ClientMessageSpeechUpdateRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageSpeechUpdateRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ClientMessageSpeechUpdateRole.Assistant,
                "user" => ClientMessageSpeechUpdateRole.User,
                _ => null,
            };
        }
    }
}