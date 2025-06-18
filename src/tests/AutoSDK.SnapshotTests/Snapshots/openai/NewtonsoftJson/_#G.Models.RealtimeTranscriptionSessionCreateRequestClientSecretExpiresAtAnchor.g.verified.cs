//HintName: G.Models.RealtimeTranscriptionSessionCreateRequestClientSecretExpiresAtAnchor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The anchor point for the ephemeral token expiration. Only `created_at` is currently supported.<br/>
    /// Default Value: created_at
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeTranscriptionSessionCreateRequestClientSecretExpiresAtAnchor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created_at")]
        CreatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionSessionCreateRequestClientSecretExpiresAtAnchorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreateRequestClientSecretExpiresAtAnchor value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreateRequestClientSecretExpiresAtAnchor.CreatedAt => "created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreateRequestClientSecretExpiresAtAnchor? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => RealtimeTranscriptionSessionCreateRequestClientSecretExpiresAtAnchor.CreatedAt,
                _ => null,
            };
        }
    }
}