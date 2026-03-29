//HintName: G.Models.EvalControllerGetPaginatedSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalControllerGetPaginatedSortOrder
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
    public static class EvalControllerGetPaginatedSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalControllerGetPaginatedSortOrder value)
        {
            return value switch
            {
                EvalControllerGetPaginatedSortOrder.Asc => "ASC",
                EvalControllerGetPaginatedSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalControllerGetPaginatedSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => EvalControllerGetPaginatedSortOrder.Asc,
                "DESC" => EvalControllerGetPaginatedSortOrder.Desc,
                _ => null,
            };
        }
    }
}