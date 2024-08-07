//HintName: G.Models.AuditLogActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of actor. Is either `session` or `api_key`.
    /// </summary>
    public enum AuditLogActorType
    {
        /// <summary>
        /// 
        /// </summary>
        Session,
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditLogActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogActorType value)
        {
            return value switch
            {
                AuditLogActorType.Session => "session",
                AuditLogActorType.ApiKey => "api_key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogActorType? ToEnum(string value)
        {
            return value switch
            {
                "session" => AuditLogActorType.Session,
                "api_key" => AuditLogActorType.ApiKey,
                _ => null,
            };
        }
    }
}