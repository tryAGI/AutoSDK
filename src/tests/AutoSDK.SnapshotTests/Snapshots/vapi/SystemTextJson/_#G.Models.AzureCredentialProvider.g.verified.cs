//HintName: G.Models.AzureCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AzureCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Azure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzureCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureCredentialProvider value)
        {
            return value switch
            {
                AzureCredentialProvider.Azure => "azure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "azure" => AzureCredentialProvider.Azure,
                _ => null,
            };
        }
    }
}