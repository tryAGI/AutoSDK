//HintName: G.Models.ListMessageApiRequestOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 查询顺序  desc倒序 asc正序 TODO 默认倒序
    /// </summary>
    public enum ListMessageApiRequestOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListMessageApiRequestOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMessageApiRequestOrder value)
        {
            return value switch
            {
                ListMessageApiRequestOrder.Asc => "asc",
                ListMessageApiRequestOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMessageApiRequestOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListMessageApiRequestOrder.Asc,
                "desc" => ListMessageApiRequestOrder.Desc,
                _ => null,
            };
        }
    }
}