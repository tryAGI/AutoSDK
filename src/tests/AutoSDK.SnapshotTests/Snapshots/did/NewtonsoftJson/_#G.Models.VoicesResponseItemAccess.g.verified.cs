//HintName: G.Models.VoicesResponseItemAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoicesResponseItemAccess
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="external-private")]
        ExternalPrivate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="premium")]
        Premium,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoicesResponseItemAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicesResponseItemAccess value)
        {
            return value switch
            {
                VoicesResponseItemAccess.ExternalPrivate => "external-private",
                VoicesResponseItemAccess.Premium => "premium",
                VoicesResponseItemAccess.Private => "private",
                VoicesResponseItemAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicesResponseItemAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => VoicesResponseItemAccess.ExternalPrivate,
                "premium" => VoicesResponseItemAccess.Premium,
                "private" => VoicesResponseItemAccess.Private,
                "public" => VoicesResponseItemAccess.Public,
                _ => null,
            };
        }
    }
}