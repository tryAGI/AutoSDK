//HintName: G.Models.ServerMessageSpeechUpdateRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the role which the speech update is for.
    /// </summary>
    public enum ServerMessageSpeechUpdateRole
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
    public static class ServerMessageSpeechUpdateRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageSpeechUpdateRole value)
        {
            return value switch
            {
                ServerMessageSpeechUpdateRole.Assistant => "assistant",
                ServerMessageSpeechUpdateRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageSpeechUpdateRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ServerMessageSpeechUpdateRole.Assistant,
                "user" => ServerMessageSpeechUpdateRole.User,
                _ => null,
            };
        }
    }
}