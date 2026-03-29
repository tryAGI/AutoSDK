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
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSStsAuthenticationArtifact" /> class.
        /// </summary>
        /// <param name="externalId">
        /// This is the optional external ID for the AWS credential
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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