//HintName: G.Models.DeployStatusOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeployStatusOut
    {
        /// <summary>
        /// Deploy Id<br/>
        /// Example: fkj843kjh8
        /// </summary>
        /// <example>fkj843kjh8</example>
        [global::Newtonsoft.Json.JsonProperty("deploy_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeployId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployStatusOut" /> class.
        /// </summary>
        /// <param name="deployId">
        /// Deploy Id<br/>
        /// Example: fkj843kjh8
        /// </param>
        public DeployStatusOut(
            string deployId)
        {
            this.DeployId = deployId ?? throw new global::System.ArgumentNullException(nameof(deployId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployStatusOut" /> class.
        /// </summary>
        public DeployStatusOut()
        {
        }
    }
}