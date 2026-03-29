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
        [global::Newtonsoft.Json.JsonProperty("versionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetDeploymentRequest" /> class.
        /// </summary>
        /// <param name="versionId">
        /// Version ID to deploy.
        /// </param>
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