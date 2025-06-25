﻿//HintName: G.Models.SecretScanningPushProtectionBypass.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretScanningPushProtectionBypass
    {
        /// <summary>
        /// The reason for bypassing push protection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SecretScanningPushProtectionBypassReasonJsonConverter))]
        public global::G.SecretScanningPushProtectionBypassReason? Reason { get; set; }

        /// <summary>
        /// The time that the bypass will expire in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expire_at")]
        public global::System.DateTime? ExpireAt { get; set; }

        /// <summary>
        /// The token type this bypass is for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_type")]
        public string? TokenType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningPushProtectionBypass" /> class.
        /// </summary>
        /// <param name="reason">
        /// The reason for bypassing push protection.
        /// </param>
        /// <param name="expireAt">
        /// The time that the bypass will expire in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="tokenType">
        /// The token type this bypass is for.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningPushProtectionBypass(
            global::G.SecretScanningPushProtectionBypassReason? reason,
            global::System.DateTime? expireAt,
            string? tokenType)
        {
            this.Reason = reason;
            this.ExpireAt = expireAt;
            this.TokenType = tokenType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningPushProtectionBypass" /> class.
        /// </summary>
        public SecretScanningPushProtectionBypass()
        {
        }
    }
}