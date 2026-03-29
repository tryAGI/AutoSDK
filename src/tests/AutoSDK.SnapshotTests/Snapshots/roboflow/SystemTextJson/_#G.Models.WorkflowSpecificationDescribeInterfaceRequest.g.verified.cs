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
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Specification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowSpecificationDescribeInterfaceRequest" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="specification"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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