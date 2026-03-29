//HintName: G.Models.ClientMessageAssistantStartedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "assistant.started" is sent when the assistant is started.
    /// </summary>
    public enum ClientMessageAssistantStartedType
    {
        /// <summary>
        /// 
        /// </summary>
        AssistantStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageAssistantStartedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageAssistantStartedType value)
        {
            return value switch
            {
                ClientMessageAssistantStartedType.AssistantStarted => "assistant.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageAssistantStartedType? ToEnum(string value)
        {
            return value switch
            {
                "assistant.started" => ClientMessageAssistantStartedType.AssistantStarted,
                _ => null,
            };
        }
    }
}