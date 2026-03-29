//HintName: G.Models.ListPhoneNumbersV2SortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: descending
    /// </summary>
    public enum ListPhoneNumbersV2SortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Ascending,
        /// <summary>
        /// 
        /// </summary>
        Descending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListPhoneNumbersV2SortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPhoneNumbersV2SortOrder value)
        {
            return value switch
            {
                ListPhoneNumbersV2SortOrder.Ascending => "ascending",
                ListPhoneNumbersV2SortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPhoneNumbersV2SortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListPhoneNumbersV2SortOrder.Ascending,
                "descending" => ListPhoneNumbersV2SortOrder.Descending,
                _ => null,
            };
        }
    }
}