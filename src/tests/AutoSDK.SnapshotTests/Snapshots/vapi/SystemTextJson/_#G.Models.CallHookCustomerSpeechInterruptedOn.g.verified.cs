//HintName: G.Models.CallHookCustomerSpeechInterruptedOn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the event that triggers this hook
    /// </summary>
    public enum CallHookCustomerSpeechInterruptedOn
    {
        /// <summary>
        /// 
        /// </summary>
        CustomerSpeechInterrupted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallHookCustomerSpeechInterruptedOnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallHookCustomerSpeechInterruptedOn value)
        {
            return value switch
            {
                CallHookCustomerSpeechInterruptedOn.CustomerSpeechInterrupted => "customer.speech.interrupted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallHookCustomerSpeechInterruptedOn? ToEnum(string value)
        {
            return value switch
            {
                "customer.speech.interrupted" => CallHookCustomerSpeechInterruptedOn.CustomerSpeechInterrupted,
                _ => null,
            };
        }
    }
}