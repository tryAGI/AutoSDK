//HintName: G.Models.PredefinedWorkflowInferenceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredefinedWorkflowInferenceRequest
    {
        /// <summary>
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Dictionary that contains each parameter defined as an input for chosen workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Inputs { get; set; }

        /// <summary>
        /// List of field that shall be excluded from the response (among those defined in workflow specification)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded_fields")]
        public global::System.Collections.Generic.IList<string>? ExcludedFields { get; set; }

        /// <summary>
        /// Flag to request Workflow run profiling. Enables Workflow profiler only when server settings allow profiling traces to be exported to clients. Only applies for Workflows definitions saved on Roboflow platform.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_profiling")]
        public bool? EnableProfiling { get; set; }

        /// <summary>
        /// Optional identifier of workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// Controls usage of cache for workflow definitions. Set this to False when you frequently modify definition saved in Roboflow app and want to fetch the newest version for the request.<br/>
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
        /// Initializes a new instance of the <see cref="PredefinedWorkflowInferenceRequest" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Dictionary that contains each parameter defined as an input for chosen workflow
        /// </param>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="excludedFields">
        /// List of field that shall be excluded from the response (among those defined in workflow specification)
        /// </param>
        /// <param name="enableProfiling">
        /// Flag to request Workflow run profiling. Enables Workflow profiler only when server settings allow profiling traces to be exported to clients. Only applies for Workflows definitions saved on Roboflow platform.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="workflowId">
        /// Optional identifier of workflow
        /// </param>
        /// <param name="useCache">
        /// Controls usage of cache for workflow definitions. Set this to False when you frequently modify definition saved in Roboflow app and want to fetch the newest version for the request.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="workflowVersionId">
        /// Specific version of the workflow to fetch. If not provided, the latest version is used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PredefinedWorkflowInferenceRequest(
            object inputs,
            string? apiKey,
            global::System.Collections.Generic.IList<string>? excludedFields,
            bool? enableProfiling,
            string? workflowId,
            bool? useCache,
            string? workflowVersionId)
        {
            this.ApiKey = apiKey;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.ExcludedFields = excludedFields;
            this.EnableProfiling = enableProfiling;
            this.WorkflowId = workflowId;
            this.UseCache = useCache;
            this.WorkflowVersionId = workflowVersionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredefinedWorkflowInferenceRequest" /> class.
        /// </summary>
        public PredefinedWorkflowInferenceRequest()
        {
        }
    }
}