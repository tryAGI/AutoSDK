//HintName: G.Models.StructuredOutputControllerFindAllSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StructuredOutputControllerFindAllSortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASC")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DESC")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StructuredOutputControllerFindAllSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StructuredOutputControllerFindAllSortOrder value)
        {
            return value switch
            {
                StructuredOutputControllerFindAllSortOrder.Asc => "ASC",
                StructuredOutputControllerFindAllSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StructuredOutputControllerFindAllSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => StructuredOutputControllerFindAllSortOrder.Asc,
                "DESC" => StructuredOutputControllerFindAllSortOrder.Desc,
                _ => null,
            };
        }
    }
}