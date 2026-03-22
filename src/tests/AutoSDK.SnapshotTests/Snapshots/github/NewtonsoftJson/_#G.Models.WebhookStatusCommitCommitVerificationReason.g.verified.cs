//HintName: G.Models.WebhookStatusCommitCommitVerificationReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookStatusCommitCommitVerificationReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bad_cert")]
        BadCert,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bad_email")]
        BadEmail,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expired_key")]
        ExpiredKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpgverify_error")]
        GpgverifyError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpgverify_unavailable")]
        GpgverifyUnavailable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid")]
        Invalid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="malformed_signature")]
        MalformedSignature,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="no_user")]
        NoUser,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_signing_key")]
        NotSigningKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ocsp_pending")]
        OcspPending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown_key")]
        UnknownKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown_signature_type")]
        UnknownSignatureType,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unsigned")]
        Unsigned,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unverified_email")]
        UnverifiedEmail,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="valid")]
        Valid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookStatusCommitCommitVerificationReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookStatusCommitCommitVerificationReason value)
        {
            return value switch
            {
                WebhookStatusCommitCommitVerificationReason.BadCert => "bad_cert",
                WebhookStatusCommitCommitVerificationReason.BadEmail => "bad_email",
                WebhookStatusCommitCommitVerificationReason.ExpiredKey => "expired_key",
                WebhookStatusCommitCommitVerificationReason.GpgverifyError => "gpgverify_error",
                WebhookStatusCommitCommitVerificationReason.GpgverifyUnavailable => "gpgverify_unavailable",
                WebhookStatusCommitCommitVerificationReason.Invalid => "invalid",
                WebhookStatusCommitCommitVerificationReason.MalformedSignature => "malformed_signature",
                WebhookStatusCommitCommitVerificationReason.NoUser => "no_user",
                WebhookStatusCommitCommitVerificationReason.NotSigningKey => "not_signing_key",
                WebhookStatusCommitCommitVerificationReason.OcspPending => "ocsp_pending",
                WebhookStatusCommitCommitVerificationReason.UnknownKey => "unknown_key",
                WebhookStatusCommitCommitVerificationReason.UnknownSignatureType => "unknown_signature_type",
                WebhookStatusCommitCommitVerificationReason.Unsigned => "unsigned",
                WebhookStatusCommitCommitVerificationReason.UnverifiedEmail => "unverified_email",
                WebhookStatusCommitCommitVerificationReason.Valid => "valid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookStatusCommitCommitVerificationReason? ToEnum(string value)
        {
            return value switch
            {
                "bad_cert" => WebhookStatusCommitCommitVerificationReason.BadCert,
                "bad_email" => WebhookStatusCommitCommitVerificationReason.BadEmail,
                "expired_key" => WebhookStatusCommitCommitVerificationReason.ExpiredKey,
                "gpgverify_error" => WebhookStatusCommitCommitVerificationReason.GpgverifyError,
                "gpgverify_unavailable" => WebhookStatusCommitCommitVerificationReason.GpgverifyUnavailable,
                "invalid" => WebhookStatusCommitCommitVerificationReason.Invalid,
                "malformed_signature" => WebhookStatusCommitCommitVerificationReason.MalformedSignature,
                "no_user" => WebhookStatusCommitCommitVerificationReason.NoUser,
                "not_signing_key" => WebhookStatusCommitCommitVerificationReason.NotSigningKey,
                "ocsp_pending" => WebhookStatusCommitCommitVerificationReason.OcspPending,
                "unknown_key" => WebhookStatusCommitCommitVerificationReason.UnknownKey,
                "unknown_signature_type" => WebhookStatusCommitCommitVerificationReason.UnknownSignatureType,
                "unsigned" => WebhookStatusCommitCommitVerificationReason.Unsigned,
                "unverified_email" => WebhookStatusCommitCommitVerificationReason.UnverifiedEmail,
                "valid" => WebhookStatusCommitCommitVerificationReason.Valid,
                _ => null,
            };
        }
    }
}