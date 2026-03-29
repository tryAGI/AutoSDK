//HintName: G.Models.ProviderResourceControllerDeleteProviderResourceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProviderResourceControllerDeleteProviderResourceProvider
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
    public static class ProviderResourceControllerDeleteProviderResourceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderResourceControllerDeleteProviderResourceProvider value)
        {
            return value switch
            {
                ProviderResourceControllerDeleteProviderResourceProvider.x11labs => "11labs",
                ProviderResourceControllerDeleteProviderResourceProvider.Cartesia => "cartesia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderResourceControllerDeleteProviderResourceProvider? ToEnum(string value)
        {
            return value switch
            {
                "11labs" => ProviderResourceControllerDeleteProviderResourceProvider.x11labs,
                "cartesia" => ProviderResourceControllerDeleteProviderResourceProvider.Cartesia,
                _ => null,
            };
        }
    }
}