//HintName: G.Models.WorkflowSpecificationInferenceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowSpecificationInferenceRequest
    {
        /// <summary>
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Dictionary that contains each parameter defined as an input for chosen workflow
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public object Inputs { get; set; } = default!;

        /// <summary>
        /// List of field that shall be excluded from the response (among those defined in workflow specification)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excluded_fields")]
        public global::System.Collections.Generic.IList<string>? ExcludedFields { get; set; }

        /// <summary>
        /// Flag to request Workflow run profiling. Enables Workflow profiler only when server settings allow profiling traces to be exported to clients. Only applies for Workflows definitions saved on Roboflow platform.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_profiling")]
        public bool? EnableProfiling { get; set; }

        /// <summary>
        /// Optional identifier of workflow
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_id")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("specification", Required = global::Newtonsoft.Json.Required.Always)]
        public object Specification { get; set; } = default!;

        /// <summary>
        /// Reserved, used internally by Roboflow to distinguish between preview and non-preview runs<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_preview")]
        public bool? IsPreview { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowSpecificationInferenceRequest" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Dictionary that contains each parameter defined as an input for chosen workflow
        /// </param>
        /// <param name="specification"></param>
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
        /// <param name="isPreview">
        /// Reserved, used internally by Roboflow to distinguish between preview and non-preview runs<br/>
        /// Default Value: false
        /// </param>
        public WorkflowSpecificationInferenceRequest(
            object inputs,
            object specification,
            string? apiKey,
            global::System.Collections.Generic.IList<string>? excludedFields,
            bool? enableProfiling,
            string? workflowId,
            bool? isPreview)
        {
            this.ApiKey = apiKey;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.ExcludedFields = excludedFields;
            this.EnableProfiling = enableProfiling;
            this.WorkflowId = workflowId;
            this.Specification = specification ?? throw new global::System.ArgumentNullException(nameof(specification));
            this.IsPreview = isPreview;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowSpecificationInferenceRequest" /> class.
        /// </summary>
        public WorkflowSpecificationInferenceRequest()
        {
        }
    }
}