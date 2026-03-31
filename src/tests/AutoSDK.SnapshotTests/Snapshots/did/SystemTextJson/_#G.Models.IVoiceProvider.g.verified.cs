//HintName: G.Models.IVoiceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum IVoiceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Amazon,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IVoiceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IVoiceProvider value)
        {
            return value switch
            {
                IVoiceProvider.Amazon => "amazon",
                IVoiceProvider.AzureOpenai => "azure-openai",
                IVoiceProvider.Elevenlabs => "elevenlabs",
                IVoiceProvider.Google => "google",
                IVoiceProvider.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IVoiceProvider? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => IVoiceProvider.Amazon,
                "azure-openai" => IVoiceProvider.AzureOpenai,
                "elevenlabs" => IVoiceProvider.Elevenlabs,
                "google" => IVoiceProvider.Google,
                "microsoft" => IVoiceProvider.Microsoft,
                _ => null,
            };
        }
    }
}