//HintName: G.Models.ListDatasetsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDatasetsOrder
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
    public static class ListDatasetsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDatasetsOrder value)
        {
            return value switch
            {
                ListDatasetsOrder.Asc => "asc",
                ListDatasetsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDatasetsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListDatasetsOrder.Asc,
                "desc" => ListDatasetsOrder.Desc,
                _ => null,
            };
        }
    }
}