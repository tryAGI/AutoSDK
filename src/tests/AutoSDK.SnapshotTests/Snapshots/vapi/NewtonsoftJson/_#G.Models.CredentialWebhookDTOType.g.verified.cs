//HintName: G.Models.CredentialWebhookDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CredentialWebhookDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auth")]
        Auth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="forward")]
        Forward,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sync")]
        Sync,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CredentialWebhookDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CredentialWebhookDTOType value)
        {
            return value switch
            {
                CredentialWebhookDTOType.Auth => "auth",
                CredentialWebhookDTOType.Forward => "forward",
                CredentialWebhookDTOType.Sync => "sync",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CredentialWebhookDTOType? ToEnum(string value)
        {
            return value switch
            {
                "auth" => CredentialWebhookDTOType.Auth,
                "forward" => CredentialWebhookDTOType.Forward,
                "sync" => CredentialWebhookDTOType.Sync,
                _ => null,
            };
        }
    }
}