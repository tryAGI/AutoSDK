//HintName: G.Models.PhoneNumberControllerFindAllPaginatedSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PhoneNumberControllerFindAllPaginatedSortOrder
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
    public static class PhoneNumberControllerFindAllPaginatedSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberControllerFindAllPaginatedSortOrder value)
        {
            return value switch
            {
                PhoneNumberControllerFindAllPaginatedSortOrder.Asc => "ASC",
                PhoneNumberControllerFindAllPaginatedSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberControllerFindAllPaginatedSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => PhoneNumberControllerFindAllPaginatedSortOrder.Asc,
                "DESC" => PhoneNumberControllerFindAllPaginatedSortOrder.Desc,
                _ => null,
            };
        }
    }
}