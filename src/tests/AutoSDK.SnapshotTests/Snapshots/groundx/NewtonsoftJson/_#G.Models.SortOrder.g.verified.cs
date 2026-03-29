//HintName: G.Models.SortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The order in which to sort results
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SortOrder
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
    public static class SortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SortOrder value)
        {
            return value switch
            {
                SortOrder.Asc => "asc",
                SortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => SortOrder.Asc,
                "desc" => SortOrder.Desc,
                _ => null,
            };
        }
    }
}