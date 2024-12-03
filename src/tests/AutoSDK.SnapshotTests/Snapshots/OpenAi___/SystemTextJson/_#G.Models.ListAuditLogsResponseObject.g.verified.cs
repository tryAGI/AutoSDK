//HintName: G.Models.ListAuditLogsResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListAuditLogsResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAuditLogsResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAuditLogsResponseObject value)
        {
            return value switch
            {
                ListAuditLogsResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAuditLogsResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ListAuditLogsResponseObject.List,
                _ => null,
            };
        }
    }
}