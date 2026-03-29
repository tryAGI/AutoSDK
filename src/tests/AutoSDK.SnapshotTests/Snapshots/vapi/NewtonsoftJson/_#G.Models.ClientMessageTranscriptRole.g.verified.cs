//HintName: G.Models.ClientMessageTranscriptRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the role for which the transcript is for.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientMessageTranscriptRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageTranscriptRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageTranscriptRole value)
        {
            return value switch
            {
                ClientMessageTranscriptRole.Assistant => "assistant",
                ClientMessageTranscriptRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageTranscriptRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ClientMessageTranscriptRole.Assistant,
                "user" => ClientMessageTranscriptRole.User,
                _ => null,
            };
        }
    }
}