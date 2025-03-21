//HintName: G.Models.RealtimeSessionCreateResponseClientSecret.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Ephemeral key returned by the API.
    /// </summary>
    public sealed partial class RealtimeSessionCreateResponseClientSecret
    {
        /// <summary>
        /// Timestamp for when the token expires. Currently, all tokens expire<br/>
        /// after one minute.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int ExpiresAt { get; set; } = default!;

        /// <summary>
        /// Ephemeral key usable in client environments to authenticate connections<br/>
        /// to the Realtime API. Use this in client-side environments rather than<br/>
        /// a standard API token, which should only be used server-side.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseClientSecret" /> class.
        /// </summary>
        /// <param name="expiresAt">
        /// Timestamp for when the token expires. Currently, all tokens expire<br/>
        /// after one minute.
        /// </param>
        /// <param name="value">
        /// Ephemeral key usable in client environments to authenticate connections<br/>
        /// to the Realtime API. Use this in client-side environments rather than<br/>
        /// a standard API token, which should only be used server-side.
        /// </param>
        public RealtimeSessionCreateResponseClientSecret(
            int expiresAt,
            string value)
        {
            this.ExpiresAt = expiresAt;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseClientSecret" /> class.
        /// </summary>
        public RealtimeSessionCreateResponseClientSecret()
        {
        }
    }
}