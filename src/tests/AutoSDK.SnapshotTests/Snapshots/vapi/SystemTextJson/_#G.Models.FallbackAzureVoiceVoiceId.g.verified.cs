//HintName: G.Models.FallbackAzureVoiceVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FallbackAzureVoiceVoiceId
    {
        /// <summary>
        /// 
        /// </summary>
        Andrew,
        /// <summary>
        /// 
        /// </summary>
        Brian,
        /// <summary>
        /// 
        /// </summary>
        Emma,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackAzureVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackAzureVoiceVoiceId value)
        {
            return value switch
            {
                FallbackAzureVoiceVoiceId.Andrew => "andrew",
                FallbackAzureVoiceVoiceId.Brian => "brian",
                FallbackAzureVoiceVoiceId.Emma => "emma",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackAzureVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "andrew" => FallbackAzureVoiceVoiceId.Andrew,
                "brian" => FallbackAzureVoiceVoiceId.Brian,
                "emma" => FallbackAzureVoiceVoiceId.Emma,
                _ => null,
            };
        }
    }
}