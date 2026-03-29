//HintName: G.Models.AzureOpenAIConfigurationAzureAuthMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication mode for Azure
    /// </summary>
    public enum AzureOpenAIConfigurationAzureAuthMode
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Entra,
        /// <summary>
        /// 
        /// </summary>
        Managed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzureOpenAIConfigurationAzureAuthModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureOpenAIConfigurationAzureAuthMode value)
        {
            return value switch
            {
                AzureOpenAIConfigurationAzureAuthMode.Default => "default",
                AzureOpenAIConfigurationAzureAuthMode.Entra => "entra",
                AzureOpenAIConfigurationAzureAuthMode.Managed => "managed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureOpenAIConfigurationAzureAuthMode? ToEnum(string value)
        {
            return value switch
            {
                "default" => AzureOpenAIConfigurationAzureAuthMode.Default,
                "entra" => AzureOpenAIConfigurationAzureAuthMode.Entra,
                "managed" => AzureOpenAIConfigurationAzureAuthMode.Managed,
                _ => null,
            };
        }
    }
}