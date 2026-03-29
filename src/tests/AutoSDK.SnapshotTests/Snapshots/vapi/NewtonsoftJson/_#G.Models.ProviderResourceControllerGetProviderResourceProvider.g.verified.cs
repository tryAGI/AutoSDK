//HintName: G.Models.ProviderResourceControllerGetProviderResourceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProviderResourceControllerGetProviderResourceProvider
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
    public static class ProviderResourceControllerGetProviderResourceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderResourceControllerGetProviderResourceProvider value)
        {
            return value switch
            {
                ProviderResourceControllerGetProviderResourceProvider.x11labs => "11labs",
                ProviderResourceControllerGetProviderResourceProvider.Cartesia => "cartesia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderResourceControllerGetProviderResourceProvider? ToEnum(string value)
        {
            return value switch
            {
                "11labs" => ProviderResourceControllerGetProviderResourceProvider.x11labs,
                "cartesia" => ProviderResourceControllerGetProviderResourceProvider.Cartesia,
                _ => null,
            };
        }
    }
}