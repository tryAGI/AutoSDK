//HintName: G.Models.AssetCloudProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cloud provider where the asset is stored
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssetCloudProvider
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
    public static class AssetCloudProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetCloudProvider value)
        {
            return value switch
            {
                AssetCloudProvider.Aws => "aws",
                AssetCloudProvider.Azure => "azure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetCloudProvider? ToEnum(string value)
        {
            return value switch
            {
                "aws" => AssetCloudProvider.Aws,
                "azure" => AssetCloudProvider.Azure,
                _ => null,
            };
        }
    }
}