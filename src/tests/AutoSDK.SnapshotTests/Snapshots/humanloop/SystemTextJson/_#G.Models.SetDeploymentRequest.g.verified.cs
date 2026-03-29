//HintName: G.Models.SetDeploymentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetDeploymentRequest
    {
        /// <summary>
        /// Version ID to deploy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetDeploymentRequest" /> class.
        /// </summary>
        /// <param name="versionId">
        /// Version ID to deploy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetDeploymentRequest(
            string versionId)
        {
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetDeploymentRequest" /> class.
        /// </summary>
        public SetDeploymentRequest()
        {
        }
    }
}