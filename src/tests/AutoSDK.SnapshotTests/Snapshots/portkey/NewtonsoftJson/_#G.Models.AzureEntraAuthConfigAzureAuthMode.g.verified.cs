//HintName: G.Models.AzureEntraAuthConfigAzureAuthMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AzureEntraAuthConfigAzureAuthMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="entra")]
        Entra,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzureEntraAuthConfigAzureAuthModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureEntraAuthConfigAzureAuthMode value)
        {
            return value switch
            {
                AzureEntraAuthConfigAzureAuthMode.Entra => "entra",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureEntraAuthConfigAzureAuthMode? ToEnum(string value)
        {
            return value switch
            {
                "entra" => AzureEntraAuthConfigAzureAuthMode.Entra,
                _ => null,
            };
        }
    }
}