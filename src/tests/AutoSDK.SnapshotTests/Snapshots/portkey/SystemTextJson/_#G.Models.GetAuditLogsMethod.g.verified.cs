//HintName: G.Models.GetAuditLogsMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAuditLogsMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAuditLogsMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAuditLogsMethod value)
        {
            return value switch
            {
                GetAuditLogsMethod.Delete => "DELETE",
                GetAuditLogsMethod.Post => "POST",
                GetAuditLogsMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAuditLogsMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => GetAuditLogsMethod.Delete,
                "POST" => GetAuditLogsMethod.Post,
                "PUT" => GetAuditLogsMethod.Put,
                _ => null,
            };
        }
    }
}