//HintName: G.Models.WebhooksSecurityAdvisoryCwe.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhooksSecurityAdvisoryCwe
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwe_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CweId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksSecurityAdvisoryCwe" /> class.
        /// </summary>
        /// <param name="cweId"></param>
        /// <param name="name"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhooksSecurityAdvisoryCwe(
            string cweId,
            string name)
        {
            this.CweId = cweId ?? throw new global::System.ArgumentNullException(nameof(cweId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksSecurityAdvisoryCwe" /> class.
        /// </summary>
        public WebhooksSecurityAdvisoryCwe()
        {
        }
    }
}