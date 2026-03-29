//HintName: G.Models.AzureManagedAuthConfigAzureAuthMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AzureManagedAuthConfigAzureAuthMode
    {
        /// <summary>
        /// 
        /// </summary>
        Managed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzureManagedAuthConfigAzureAuthModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureManagedAuthConfigAzureAuthMode value)
        {
            return value switch
            {
                AzureManagedAuthConfigAzureAuthMode.Managed => "managed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureManagedAuthConfigAzureAuthMode? ToEnum(string value)
        {
            return value switch
            {
                "managed" => AzureManagedAuthConfigAzureAuthMode.Managed,
                _ => null,
            };
        }
    }
}