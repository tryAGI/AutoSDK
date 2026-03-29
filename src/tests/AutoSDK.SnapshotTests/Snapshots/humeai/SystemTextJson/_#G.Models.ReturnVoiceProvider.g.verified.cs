//HintName: G.Models.ReturnVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReturnVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        HumeAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReturnVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReturnVoiceProvider value)
        {
            return value switch
            {
                ReturnVoiceProvider.Custom => "CUSTOM",
                ReturnVoiceProvider.HumeAi => "HUME_AI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReturnVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "CUSTOM" => ReturnVoiceProvider.Custom,
                "HUME_AI" => ReturnVoiceProvider.HumeAi,
                _ => null,
            };
        }
    }
}