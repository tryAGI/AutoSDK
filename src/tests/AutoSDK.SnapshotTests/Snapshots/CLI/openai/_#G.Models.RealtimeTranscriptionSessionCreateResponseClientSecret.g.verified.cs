﻿//HintName: G.Models.RealtimeTranscriptionSessionCreateResponseClientSecret.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Ephemeral key returned by the API. Only present when the session is<br/>
    /// created on the server via REST API.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateResponseClientSecret
    {
        /// <summary>
        /// Ephemeral key usable in client environments to authenticate connections<br/>
        /// to the Realtime API. Use this in client-side environments rather than<br/>
        /// a standard API token, which should only be used server-side.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Timestamp for when the token expires. Currently, all tokens expire<br/>
        /// after one minute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseClientSecret" /> class.
        /// </summary>
        /// <param name="value">
        /// Ephemeral key usable in client environments to authenticate connections<br/>
        /// to the Realtime API. Use this in client-side environments rather than<br/>
        /// a standard API token, which should only be used server-side.
        /// </param>
        /// <param name="expiresAt">
        /// Timestamp for when the token expires. Currently, all tokens expire<br/>
        /// after one minute.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreateResponseClientSecret(
            string value,
            int expiresAt)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseClientSecret" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateResponseClientSecret()
        {
        }
    }
}