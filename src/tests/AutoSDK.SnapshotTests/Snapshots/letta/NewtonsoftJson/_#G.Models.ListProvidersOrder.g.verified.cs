//HintName: G.Models.ListProvidersOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for providers by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListProvidersOrder
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
    public static class ListProvidersOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProvidersOrder value)
        {
            return value switch
            {
                ListProvidersOrder.Asc => "asc",
                ListProvidersOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProvidersOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListProvidersOrder.Asc,
                "desc" => ListProvidersOrder.Desc,
                _ => null,
            };
        }
    }
}