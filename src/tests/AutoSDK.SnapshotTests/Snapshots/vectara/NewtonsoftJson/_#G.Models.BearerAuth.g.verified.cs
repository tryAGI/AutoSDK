//HintName: G.Models.BearerAuth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Bearer token authentication
    /// </summary>
    public sealed partial class BearerAuth
    {
        /// <summary>
        /// Must be "bearer" for bearer token auth<br/>
        /// Default Value: bearer
        /// </summary>
        /// <default>"bearer"</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The bearer token to use for authentication
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BearerAuth" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "bearer" for bearer token auth<br/>
        /// Default Value: bearer
        /// </param>
        /// <param name="token">
        /// The bearer token to use for authentication
        /// </param>
        public BearerAuth(
            string type,
            string token)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BearerAuth" /> class.
        /// </summary>
        public BearerAuth()
        {
        }
    }
}