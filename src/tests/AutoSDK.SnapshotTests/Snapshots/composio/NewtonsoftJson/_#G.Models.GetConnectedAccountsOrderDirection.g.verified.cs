//HintName: G.Models.GetConnectedAccountsOrderDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The order direction of the connected accounts<br/>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConnectedAccountsOrderDirection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsOrderDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsOrderDirection value)
        {
            return value switch
            {
                GetConnectedAccountsOrderDirection.Asc => "asc",
                GetConnectedAccountsOrderDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsOrderDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetConnectedAccountsOrderDirection.Asc,
                "desc" => GetConnectedAccountsOrderDirection.Desc,
                _ => null,
            };
        }
    }
}