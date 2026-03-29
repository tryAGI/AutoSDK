//HintName: G.Models.ServerMessageTranscriptRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the role for which the transcript is for.
    /// </summary>
    public enum ServerMessageTranscriptRole
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
    public static class ServerMessageTranscriptRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageTranscriptRole value)
        {
            return value switch
            {
                ServerMessageTranscriptRole.Assistant => "assistant",
                ServerMessageTranscriptRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageTranscriptRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ServerMessageTranscriptRole.Assistant,
                "user" => ServerMessageTranscriptRole.User,
                _ => null,
            };
        }
    }
}