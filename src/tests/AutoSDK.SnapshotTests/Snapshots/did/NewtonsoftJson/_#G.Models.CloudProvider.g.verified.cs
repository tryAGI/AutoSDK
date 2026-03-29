//HintName: G.Models.CloudProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cloud provider for asset storage
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CloudProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="aws")]
        Aws,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure")]
        Azure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CloudProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CloudProvider value)
        {
            return value switch
            {
                CloudProvider.Aws => "aws",
                CloudProvider.Azure => "azure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CloudProvider? ToEnum(string value)
        {
            return value switch
            {
                "aws" => CloudProvider.Aws,
                "azure" => CloudProvider.Azure,
                _ => null,
            };
        }
    }
}