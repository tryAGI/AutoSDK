//HintName: G.Models.ListIdentitiesOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for identities by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListIdentitiesOrder
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
    public static class ListIdentitiesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListIdentitiesOrder value)
        {
            return value switch
            {
                ListIdentitiesOrder.Asc => "asc",
                ListIdentitiesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListIdentitiesOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListIdentitiesOrder.Asc,
                "desc" => ListIdentitiesOrder.Desc,
                _ => null,
            };
        }
    }
}