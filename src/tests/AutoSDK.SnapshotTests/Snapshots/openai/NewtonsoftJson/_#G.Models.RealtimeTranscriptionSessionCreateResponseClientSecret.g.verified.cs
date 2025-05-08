//HintName: G.Models.RealtimeTranscriptionSessionCreateResponseClientSecret.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Timestamp for when the token expires. Currently, all tokens expire<br/>
        /// after one minute.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int ExpiresAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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