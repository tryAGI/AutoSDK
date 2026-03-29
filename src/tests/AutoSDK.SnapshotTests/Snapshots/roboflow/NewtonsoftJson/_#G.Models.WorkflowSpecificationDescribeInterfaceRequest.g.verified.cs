//HintName: G.Models.WorkflowSpecificationDescribeInterfaceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowSpecificationDescribeInterfaceRequest
    {
        /// <summary>
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("specification", Required = global::Newtonsoft.Json.Required.Always)]
        public object Specification { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowSpecificationDescribeInterfaceRequest" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="specification"></param>
        public WorkflowSpecificationDescribeInterfaceRequest(
            string apiKey,
            object specification)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Specification = specification ?? throw new global::System.ArgumentNullException(nameof(specification));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowSpecificationDescribeInterfaceRequest" /> class.
        /// </summary>
        public WorkflowSpecificationDescribeInterfaceRequest()
        {
        }
    }
}