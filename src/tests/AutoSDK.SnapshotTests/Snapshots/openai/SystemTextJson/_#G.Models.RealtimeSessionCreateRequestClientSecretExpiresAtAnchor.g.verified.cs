//HintName: G.Models.RealtimeSessionCreateRequestClientSecretExpiresAtAnchor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The anchor point for the ephemeral token expiration. Only `created_at` is currently supported.<br/>
    /// Default Value: created_at
    /// </summary>
    public enum RealtimeSessionCreateRequestClientSecretExpiresAtAnchor
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateRequestClientSecretExpiresAtAnchorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestClientSecretExpiresAtAnchor value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestClientSecretExpiresAtAnchor.CreatedAt => "created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestClientSecretExpiresAtAnchor? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => RealtimeSessionCreateRequestClientSecretExpiresAtAnchor.CreatedAt,
                _ => null,
            };
        }
    }
}