//HintName: G.Models.Providers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Providers
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
    public static class ProvidersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Providers value)
        {
            return value switch
            {
                Providers.Amazon => "amazon",
                Providers.AzureOpenai => "azure-openai",
                Providers.Elevenlabs => "elevenlabs",
                Providers.Google => "google",
                Providers.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Providers? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => Providers.Amazon,
                "azure-openai" => Providers.AzureOpenai,
                "elevenlabs" => Providers.Elevenlabs,
                "google" => Providers.Google,
                "microsoft" => Providers.Microsoft,
                _ => null,
            };
        }
    }
}