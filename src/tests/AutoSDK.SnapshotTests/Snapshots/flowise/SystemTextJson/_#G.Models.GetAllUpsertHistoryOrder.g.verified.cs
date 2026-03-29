//HintName: G.Models.GetAllUpsertHistoryOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: ASC
    /// </summary>
    public enum GetAllUpsertHistoryOrder
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
    public static class GetAllUpsertHistoryOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllUpsertHistoryOrder value)
        {
            return value switch
            {
                GetAllUpsertHistoryOrder.Asc => "ASC",
                GetAllUpsertHistoryOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllUpsertHistoryOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => GetAllUpsertHistoryOrder.Asc,
                "DESC" => GetAllUpsertHistoryOrder.Desc,
                _ => null,
            };
        }
    }
}