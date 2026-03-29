//HintName: G.Models.AzureDefaultAuthConfigAzureAuthMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AzureDefaultAuthConfigAzureAuthMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzureDefaultAuthConfigAzureAuthModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureDefaultAuthConfigAzureAuthMode value)
        {
            return value switch
            {
                AzureDefaultAuthConfigAzureAuthMode.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureDefaultAuthConfigAzureAuthMode? ToEnum(string value)
        {
            return value switch
            {
                "default" => AzureDefaultAuthConfigAzureAuthMode.Default,
                _ => null,
            };
        }
    }
}