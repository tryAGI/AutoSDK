//HintName: G.Models.SearchLabelsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SearchLabelsOrder
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchLabelsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchLabelsOrder value)
        {
            return value switch
            {
                SearchLabelsOrder.Desc => "desc",
                SearchLabelsOrder.Asc => "asc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchLabelsOrder? ToEnum(string value)
        {
            return value switch
            {
                "desc" => SearchLabelsOrder.Desc,
                "asc" => SearchLabelsOrder.Asc,
                _ => null,
            };
        }
    }
}