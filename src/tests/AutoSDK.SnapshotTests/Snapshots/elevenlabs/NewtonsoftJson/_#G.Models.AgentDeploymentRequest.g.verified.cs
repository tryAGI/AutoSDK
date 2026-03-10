//HintName: G.Models.AgentDeploymentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentDeploymentRequest
    {
        /// <summary>
        /// List of deployment requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AgentDeploymentRequestItem> Requests { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDeploymentRequest" /> class.
        /// </summary>
        /// <param name="requests">
        /// List of deployment requests
        /// </param>
        public AgentDeploymentRequest(
            global::System.Collections.Generic.IList<global::G.AgentDeploymentRequestItem> requests)
        {
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDeploymentRequest" /> class.
        /// </summary>
        public AgentDeploymentRequest()
        {
        }
    }
}