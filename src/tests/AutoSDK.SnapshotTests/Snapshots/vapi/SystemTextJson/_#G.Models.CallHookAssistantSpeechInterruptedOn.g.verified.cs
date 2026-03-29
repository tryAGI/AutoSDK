//HintName: G.Models.CallHookAssistantSpeechInterruptedOn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the event that triggers this hook
    /// </summary>
    public enum CallHookAssistantSpeechInterruptedOn
    {
        /// <summary>
        /// 
        /// </summary>
        AssistantSpeechInterrupted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallHookAssistantSpeechInterruptedOnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallHookAssistantSpeechInterruptedOn value)
        {
            return value switch
            {
                CallHookAssistantSpeechInterruptedOn.AssistantSpeechInterrupted => "assistant.speech.interrupted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallHookAssistantSpeechInterruptedOn? ToEnum(string value)
        {
            return value switch
            {
                "assistant.speech.interrupted" => CallHookAssistantSpeechInterruptedOn.AssistantSpeechInterrupted,
                _ => null,
            };
        }
    }
}