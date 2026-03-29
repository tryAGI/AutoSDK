//HintName: G.Models.AzureAIConfigurationAzureAuthMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication mode for Azure AI
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AzureAIConfigurationAzureAuthMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="entra")]
        Entra,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="managed")]
        Managed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzureAIConfigurationAzureAuthModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureAIConfigurationAzureAuthMode value)
        {
            return value switch
            {
                AzureAIConfigurationAzureAuthMode.Default => "default",
                AzureAIConfigurationAzureAuthMode.Entra => "entra",
                AzureAIConfigurationAzureAuthMode.Managed => "managed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureAIConfigurationAzureAuthMode? ToEnum(string value)
        {
            return value switch
            {
                "default" => AzureAIConfigurationAzureAuthMode.Default,
                "entra" => AzureAIConfigurationAzureAuthMode.Entra,
                "managed" => AzureAIConfigurationAzureAuthMode.Managed,
                _ => null,
            };
        }
    }
}