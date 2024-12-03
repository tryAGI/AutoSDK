//HintName: G.Models.PagesHttpsCertificate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PagesHttpsCertificate
    {
        /// <summary>
        /// Example: approved
        /// </summary>
        /// <example>approved</example>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PagesHttpsCertificateState State { get; set; } = default!;

        /// <summary>
        /// Example: Certificate is approved
        /// </summary>
        /// <example>Certificate is approved</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Array of the domain set and its alternate name (if it is configured)<br/>
        /// Example: [example.com, www.example.com]
        /// </summary>
        /// <example>[example.com, www.example.com]</example>
        [global::Newtonsoft.Json.JsonProperty("domains", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Domains { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PagesHttpsCertificate" /> class.
        /// </summary>
        /// <param name="state">
        /// Example: approved
        /// </param>
        /// <param name="description">
        /// Example: Certificate is approved
        /// </param>
        /// <param name="domains">
        /// Array of the domain set and its alternate name (if it is configured)<br/>
        /// Example: [example.com, www.example.com]
        /// </param>
        /// <param name="expiresAt"></param>
        public PagesHttpsCertificate(
            global::G.PagesHttpsCertificateState state,
            string description,
            global::System.Collections.Generic.IList<string> domains,
            global::System.DateTime? expiresAt)
        {
            this.State = state;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Domains = domains ?? throw new global::System.ArgumentNullException(nameof(domains));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagesHttpsCertificate" /> class.
        /// </summary>
        public PagesHttpsCertificate()
        {
        }
    }
}