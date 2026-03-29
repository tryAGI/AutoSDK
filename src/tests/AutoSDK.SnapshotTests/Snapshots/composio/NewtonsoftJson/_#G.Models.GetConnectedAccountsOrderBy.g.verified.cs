//HintName: G.Models.GetConnectedAccountsOrderBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The order by of the connected accounts<br/>
    /// Default Value: created_at
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConnectedAccountsOrderBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created_at")]
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="updated_at")]
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsOrderBy value)
        {
            return value switch
            {
                GetConnectedAccountsOrderBy.CreatedAt => "created_at",
                GetConnectedAccountsOrderBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => GetConnectedAccountsOrderBy.CreatedAt,
                "updated_at" => GetConnectedAccountsOrderBy.UpdatedAt,
                _ => null,
            };
        }
    }
}