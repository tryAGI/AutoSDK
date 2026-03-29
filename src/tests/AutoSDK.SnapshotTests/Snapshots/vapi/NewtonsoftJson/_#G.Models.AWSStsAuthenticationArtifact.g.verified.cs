//HintName: G.Models.AWSStsAuthenticationArtifact.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AWSStsAuthenticationArtifact
    {
        /// <summary>
        /// This is the optional external ID for the AWS credential
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("externalId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExternalId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSStsAuthenticationArtifact" /> class.
        /// </summary>
        /// <param name="externalId">
        /// This is the optional external ID for the AWS credential
        /// </param>
        public AWSStsAuthenticationArtifact(
            string externalId)
        {
            this.ExternalId = externalId ?? throw new global::System.ArgumentNullException(nameof(externalId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSStsAuthenticationArtifact" /> class.
        /// </summary>
        public AWSStsAuthenticationArtifact()
        {
        }
    }
}