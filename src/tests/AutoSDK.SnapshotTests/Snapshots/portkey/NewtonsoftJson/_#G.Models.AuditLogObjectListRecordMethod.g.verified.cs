//HintName: G.Models.AuditLogObjectListRecordMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// HTTP method used for the request
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AuditLogObjectListRecordMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DELETE")]
        Delete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="POST")]
        Post,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PUT")]
        Put,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditLogObjectListRecordMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogObjectListRecordMethod value)
        {
            return value switch
            {
                AuditLogObjectListRecordMethod.Delete => "DELETE",
                AuditLogObjectListRecordMethod.Post => "POST",
                AuditLogObjectListRecordMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogObjectListRecordMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => AuditLogObjectListRecordMethod.Delete,
                "POST" => AuditLogObjectListRecordMethod.Post,
                "PUT" => AuditLogObjectListRecordMethod.Put,
                _ => null,
            };
        }
    }
}