//HintName: G.Models.GetClientKeyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetClientKeyResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_domains", Required = global::Newtonsoft.Json.Required.Always)]
        public object AllowedDomains { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_key", Required = global::Newtonsoft.Json.Required.Always)]
        public object ClientKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClientKeyResponse" /> class.
        /// </summary>
        /// <param name="allowedDomains"></param>
        /// <param name="clientKey"></param>
        public GetClientKeyResponse(
            object allowedDomains,
            object clientKey)
        {
            this.AllowedDomains = allowedDomains ?? throw new global::System.ArgumentNullException(nameof(allowedDomains));
            this.ClientKey = clientKey ?? throw new global::System.ArgumentNullException(nameof(clientKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClientKeyResponse" /> class.
        /// </summary>
        public GetClientKeyResponse()
        {
        }
    }
}