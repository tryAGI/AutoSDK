//HintName: G.Models.UpdateClientKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateClientKeyRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_domains", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AllowedDomains { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateClientKeyRequest" /> class.
        /// </summary>
        /// <param name="allowedDomains"></param>
        public UpdateClientKeyRequest(
            global::System.Collections.Generic.IList<string> allowedDomains)
        {
            this.AllowedDomains = allowedDomains ?? throw new global::System.ArgumentNullException(nameof(allowedDomains));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateClientKeyRequest" /> class.
        /// </summary>
        public UpdateClientKeyRequest()
        {
        }
    }
}