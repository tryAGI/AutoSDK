//HintName: G.Models.ExportChatDTOSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the sort order for pagination. Defaults to 'DESC'.
    /// </summary>
    public enum ExportChatDTOSortOrder
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
    public static class ExportChatDTOSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportChatDTOSortOrder value)
        {
            return value switch
            {
                ExportChatDTOSortOrder.Asc => "ASC",
                ExportChatDTOSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportChatDTOSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => ExportChatDTOSortOrder.Asc,
                "DESC" => ExportChatDTOSortOrder.Desc,
                _ => null,
            };
        }
    }
}