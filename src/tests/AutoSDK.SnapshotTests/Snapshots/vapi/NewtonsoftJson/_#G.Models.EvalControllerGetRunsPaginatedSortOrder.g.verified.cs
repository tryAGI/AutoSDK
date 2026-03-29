//HintName: G.Models.EvalControllerGetRunsPaginatedSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalControllerGetRunsPaginatedSortOrder
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
    public static class EvalControllerGetRunsPaginatedSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalControllerGetRunsPaginatedSortOrder value)
        {
            return value switch
            {
                EvalControllerGetRunsPaginatedSortOrder.Asc => "ASC",
                EvalControllerGetRunsPaginatedSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalControllerGetRunsPaginatedSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => EvalControllerGetRunsPaginatedSortOrder.Asc,
                "DESC" => EvalControllerGetRunsPaginatedSortOrder.Desc,
                _ => null,
            };
        }
    }
}