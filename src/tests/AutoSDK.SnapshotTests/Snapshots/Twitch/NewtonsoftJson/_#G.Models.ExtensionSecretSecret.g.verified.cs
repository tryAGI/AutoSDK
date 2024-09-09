//HintName: G.Models.ExtensionSecretSecret.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtensionSecretSecret
    {
        /// <summary>
        /// The raw secret that you use with JWT encoding.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) that you may begin using this secret to sign a JWT.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ActiveAt { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) that you must stop using this secret to decode a JWT.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ExpiresAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}