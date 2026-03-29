//HintName: G.Models.ProviderResourceControllerGetProviderResourcesPaginatedProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProviderResourceControllerGetProviderResourcesPaginatedProvider
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
    public static class ProviderResourceControllerGetProviderResourcesPaginatedProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderResourceControllerGetProviderResourcesPaginatedProvider value)
        {
            return value switch
            {
                ProviderResourceControllerGetProviderResourcesPaginatedProvider.x11labs => "11labs",
                ProviderResourceControllerGetProviderResourcesPaginatedProvider.Cartesia => "cartesia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderResourceControllerGetProviderResourcesPaginatedProvider? ToEnum(string value)
        {
            return value switch
            {
                "11labs" => ProviderResourceControllerGetProviderResourcesPaginatedProvider.x11labs,
                "cartesia" => ProviderResourceControllerGetProviderResourcesPaginatedProvider.Cartesia,
                _ => null,
            };
        }
    }
}