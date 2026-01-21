//HintName: G.Models.DeployResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeployResult
    {
        /// <summary>
        /// Deploy Id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deploy_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeployId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployResult" /> class.
        /// </summary>
        /// <param name="deployId">
        /// Deploy Id
        /// </param>
        public DeployResult(
            string deployId)
        {
            this.DeployId = deployId ?? throw new global::System.ArgumentNullException(nameof(deployId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployResult" /> class.
        /// </summary>
        public DeployResult()
        {
        }
    }
}