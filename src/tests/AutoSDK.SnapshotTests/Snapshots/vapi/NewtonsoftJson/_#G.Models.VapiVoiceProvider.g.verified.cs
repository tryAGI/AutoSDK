//HintName: G.Models.VapiVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VapiVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vapi")]
        Vapi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VapiVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiVoiceProvider value)
        {
            return value switch
            {
                VapiVoiceProvider.Vapi => "vapi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "vapi" => VapiVoiceProvider.Vapi,
                _ => null,
            };
        }
    }
}