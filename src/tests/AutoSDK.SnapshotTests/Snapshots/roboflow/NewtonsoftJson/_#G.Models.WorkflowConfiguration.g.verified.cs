//HintName: G.Models.WorkflowConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"WorkflowConfiguration"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "WorkflowConfiguration";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_specification")]
        public object? WorkflowSpecification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_name")]
        public string? WorkspaceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_id")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_version_id")]
        public string? WorkflowVersionId { get; set; }

        /// <summary>
        /// Default Value: image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_input_name")]
        public string? ImageInputName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflows_parameters")]
        public object? WorkflowsParameters { get; set; }

        /// <summary>
        /// Default Value: 4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflows_thread_pool_workers")]
        public int? WorkflowsThreadPoolWorkers { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancel_thread_pool_tasks_on_exit")]
        public bool? CancelThreadPoolTasksOnExit { get; set; }

        /// <summary>
        /// Default Value: video_metadata
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_metadata_input_name")]
        public string? VideoMetadataInputName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowConfiguration" /> class.
        /// </summary>
        /// <param name="workflowSpecification"></param>
        /// <param name="workspaceName"></param>
        /// <param name="workflowId"></param>
        /// <param name="workflowVersionId"></param>
        /// <param name="imageInputName">
        /// Default Value: image
        /// </param>
        /// <param name="workflowsParameters"></param>
        /// <param name="workflowsThreadPoolWorkers">
        /// Default Value: 4
        /// </param>
        /// <param name="cancelThreadPoolTasksOnExit">
        /// Default Value: true
        /// </param>
        /// <param name="videoMetadataInputName">
        /// Default Value: video_metadata
        /// </param>
        /// <param name="type"></param>
        public WorkflowConfiguration(
            object? workflowSpecification,
            string? workspaceName,
            string? workflowId,
            string? workflowVersionId,
            string? imageInputName,
            object? workflowsParameters,
            int? workflowsThreadPoolWorkers,
            bool? cancelThreadPoolTasksOnExit,
            string? videoMetadataInputName,
            string type = "WorkflowConfiguration")
        {
            this.Type = type;
            this.WorkflowSpecification = workflowSpecification;
            this.WorkspaceName = workspaceName;
            this.WorkflowId = workflowId;
            this.WorkflowVersionId = workflowVersionId;
            this.ImageInputName = imageInputName;
            this.WorkflowsParameters = workflowsParameters;
            this.WorkflowsThreadPoolWorkers = workflowsThreadPoolWorkers;
            this.CancelThreadPoolTasksOnExit = cancelThreadPoolTasksOnExit;
            this.VideoMetadataInputName = videoMetadataInputName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowConfiguration" /> class.
        /// </summary>
        public WorkflowConfiguration()
        {
        }
    }
}