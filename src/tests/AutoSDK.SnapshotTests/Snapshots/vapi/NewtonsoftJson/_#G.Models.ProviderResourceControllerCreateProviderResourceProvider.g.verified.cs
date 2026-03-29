//HintName: G.Models.ProviderResourceControllerCreateProviderResourceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProviderResourceControllerCreateProviderResourceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="11labs")]
        x11labs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cartesia")]
        Cartesia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderResourceControllerCreateProviderResourceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderResourceControllerCreateProviderResourceProvider value)
        {
            return value switch
            {
                ProviderResourceControllerCreateProviderResourceProvider.x11labs => "11labs",
                ProviderResourceControllerCreateProviderResourceProvider.Cartesia => "cartesia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderResourceControllerCreateProviderResourceProvider? ToEnum(string value)
        {
            return value switch
            {
                "11labs" => ProviderResourceControllerCreateProviderResourceProvider.x11labs,
                "cartesia" => ProviderResourceControllerCreateProviderResourceProvider.Cartesia,
                _ => null,
            };
        }
    }
}