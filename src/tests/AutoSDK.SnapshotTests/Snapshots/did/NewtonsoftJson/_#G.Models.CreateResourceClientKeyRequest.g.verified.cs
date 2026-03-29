//HintName: G.Models.CreateResourceClientKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateResourceClientKeyRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_domains", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AllowedDomains { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResourceClientKeyRequest" /> class.
        /// </summary>
        /// <param name="allowedDomains"></param>
        /// <param name="name"></param>
        public CreateResourceClientKeyRequest(
            global::System.Collections.Generic.IList<string> allowedDomains,
            string? name)
        {
            this.AllowedDomains = allowedDomains ?? throw new global::System.ArgumentNullException(nameof(allowedDomains));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResourceClientKeyRequest" /> class.
        /// </summary>
        public CreateResourceClientKeyRequest()
        {
        }
    }
}