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
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PagesHttpsCertificateStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PagesHttpsCertificateState State { get; set; }

        /// <summary>
        /// Example: Certificate is approved
        /// </summary>
        /// <example>Certificate is approved</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Array of the domain set and its alternate name (if it is configured)<br/>
        /// Example: [example.com, www.example.com]
        /// </summary>
        /// <example>[example.com, www.example.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Domains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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