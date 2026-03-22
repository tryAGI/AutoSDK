//HintName: G.Models.AuditLogActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of actor. Is either `session` or `api_key`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AuditLogActorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api_key")]
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session")]
        Session,
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
                AuditLogActorType.ApiKey => "api_key",
                AuditLogActorType.Session => "session",
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
                "api_key" => AuditLogActorType.ApiKey,
                "session" => AuditLogActorType.Session,
                _ => null,
            };
        }
    }
}