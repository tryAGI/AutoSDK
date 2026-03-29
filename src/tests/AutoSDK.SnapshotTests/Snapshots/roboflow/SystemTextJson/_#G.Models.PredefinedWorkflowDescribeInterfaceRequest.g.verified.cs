//HintName: G.Models.PredefinedWorkflowDescribeInterfaceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredefinedWorkflowDescribeInterfaceRequest
    {
        /// <summary>
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Controls usage of cache for workflow definitions. Set this to False when you frequently modify definition saved in Roboflow app and want to fetch the newest version for the request. Only applies for Workflows definitions saved on Roboflow platform.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_cache")]
        public bool? UseCache { get; set; }

        /// <summary>
        /// Specific version of the workflow to fetch. If not provided, the latest version is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_version_id")]
        public string? WorkflowVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredefinedWorkflowDescribeInterfaceRequest" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="useCache">
        /// Controls usage of cache for workflow definitions. Set this to False when you frequently modify definition saved in Roboflow app and want to fetch the newest version for the request. Only applies for Workflows definitions saved on Roboflow platform.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="workflowVersionId">
        /// Specific version of the workflow to fetch. If not provided, the latest version is used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PredefinedWorkflowDescribeInterfaceRequest(
            string apiKey,
            bool? useCache,
            string? workflowVersionId)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.UseCache = useCache;
            this.WorkflowVersionId = workflowVersionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredefinedWorkflowDescribeInterfaceRequest" /> class.
        /// </summary>
        public PredefinedWorkflowDescribeInterfaceRequest()
        {
        }
    }
}