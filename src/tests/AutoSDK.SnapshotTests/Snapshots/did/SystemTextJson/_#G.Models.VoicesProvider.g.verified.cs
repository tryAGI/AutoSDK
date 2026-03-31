//HintName: G.Models.VoicesProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoicesProvider
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
    public static class VoicesProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicesProvider value)
        {
            return value switch
            {
                VoicesProvider.Amazon => "amazon",
                VoicesProvider.AzureOpenai => "azure-openai",
                VoicesProvider.Elevenlabs => "elevenlabs",
                VoicesProvider.Google => "google",
                VoicesProvider.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicesProvider? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => VoicesProvider.Amazon,
                "azure-openai" => VoicesProvider.AzureOpenai,
                "elevenlabs" => VoicesProvider.Elevenlabs,
                "google" => VoicesProvider.Google,
                "microsoft" => VoicesProvider.Microsoft,
                _ => null,
            };
        }
    }
}