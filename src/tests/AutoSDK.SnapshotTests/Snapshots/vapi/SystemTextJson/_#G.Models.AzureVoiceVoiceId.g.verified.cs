//HintName: G.Models.AzureVoiceVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AzureVoiceVoiceId
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
    public static class AzureVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureVoiceVoiceId value)
        {
            return value switch
            {
                AzureVoiceVoiceId.Andrew => "andrew",
                AzureVoiceVoiceId.Brian => "brian",
                AzureVoiceVoiceId.Emma => "emma",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "andrew" => AzureVoiceVoiceId.Andrew,
                "brian" => AzureVoiceVoiceId.Brian,
                "emma" => AzureVoiceVoiceId.Emma,
                _ => null,
            };
        }
    }
}