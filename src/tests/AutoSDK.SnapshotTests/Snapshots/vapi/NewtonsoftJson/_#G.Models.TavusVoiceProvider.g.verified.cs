//HintName: G.Models.TavusVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the voice provider that will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TavusVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tavus")]
        Tavus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TavusVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TavusVoiceProvider value)
        {
            return value switch
            {
                TavusVoiceProvider.Tavus => "tavus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TavusVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "tavus" => TavusVoiceProvider.Tavus,
                _ => null,
            };
        }
    }
}