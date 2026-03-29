//HintName: G.Models.CartesiaTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CartesiaTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cartesia")]
        Cartesia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CartesiaTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CartesiaTranscriberProvider value)
        {
            return value switch
            {
                CartesiaTranscriberProvider.Cartesia => "cartesia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CartesiaTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "cartesia" => CartesiaTranscriberProvider.Cartesia,
                _ => null,
            };
        }
    }
}