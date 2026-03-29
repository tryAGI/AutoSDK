//HintName: G.Models.ApiTasksAnnotationsCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"ground_truth":true,"result":[{"from_name":"bboxes","image_rotation":0,"original_height":1080,"original_width":1920,"to_name":"image","type":"rectanglelabels","value":{"height":60,"rotation":0,"values":{"rectanglelabels":["Person"]},"width":50,"x":20,"y":30}}],"was_cancelled":false}
    /// </summary>
    public sealed partial class ApiTasksAnnotationsCreateRequest
    {
        /// <summary>
        /// User ID of the person who created this annotation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_by")]
        public int? CompletedBy { get; set; }

        /// <summary>
        /// This annotation is a Ground Truth
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ground_truth")]
        public bool? GroundTruth { get; set; }

        /// <summary>
        /// How much time it took to annotate the task (in seconds)<br/>
        /// Example: 100.5
        /// </summary>
        /// <example>100.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lead_time")]
        public double? LeadTime { get; set; }

        /// <summary>
        /// Project ID for this annotation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Labeling result in JSON format. Read more about the format in [the Label Studio documentation.](https://labelstud.io/guide/task_format)<br/>
        /// Example: [{"from_name":"bboxes","image_rotation":0,"original_height":1080,"original_width":1920,"to_name":"image","type":"rectanglelabels","value":{"height":60,"rotation":0,"values":{"rectanglelabels":["Person"]},"width":50,"x":20,"y":30}}]
        /// </summary>
        /// <example>[{"from_name":"bboxes","image_rotation":0,"original_height":1080,"original_width":1920,"to_name":"image","type":"rectanglelabels","value":{"height":60,"rotation":0,"values":{"rectanglelabels":["Person"]},"width":50,"x":20,"y":30}}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::System.Collections.Generic.IList<object>? Result { get; set; }

        /// <summary>
        /// Corresponding task for this annotation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public int? Task { get; set; }

        /// <summary>
        /// Last user who updated this annotation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public int? UpdatedBy { get; set; }

        /// <summary>
        /// User skipped the task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("was_cancelled")]
        public bool? WasCancelled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTasksAnnotationsCreateRequest" /> class.
        /// </summary>
        /// <param name="completedBy">
        /// User ID of the person who created this annotation
        /// </param>
        /// <param name="groundTruth">
        /// This annotation is a Ground Truth
        /// </param>
        /// <param name="leadTime">
        /// How much time it took to annotate the task (in seconds)<br/>
        /// Example: 100.5
        /// </param>
        /// <param name="project">
        /// Project ID for this annotation
        /// </param>
        /// <param name="result">
        /// Labeling result in JSON format. Read more about the format in [the Label Studio documentation.](https://labelstud.io/guide/task_format)<br/>
        /// Example: [{"from_name":"bboxes","image_rotation":0,"original_height":1080,"original_width":1920,"to_name":"image","type":"rectanglelabels","value":{"height":60,"rotation":0,"values":{"rectanglelabels":["Person"]},"width":50,"x":20,"y":30}}]
        /// </param>
        /// <param name="task">
        /// Corresponding task for this annotation
        /// </param>
        /// <param name="updatedBy">
        /// Last user who updated this annotation
        /// </param>
        /// <param name="wasCancelled">
        /// User skipped the task
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiTasksAnnotationsCreateRequest(
            int? completedBy,
            bool? groundTruth,
            double? leadTime,
            int? project,
            global::System.Collections.Generic.IList<object>? result,
            int? task,
            int? updatedBy,
            bool? wasCancelled)
        {
            this.CompletedBy = completedBy;
            this.GroundTruth = groundTruth;
            this.LeadTime = leadTime;
            this.Project = project;
            this.Result = result;
            this.Task = task;
            this.UpdatedBy = updatedBy;
            this.WasCancelled = wasCancelled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTasksAnnotationsCreateRequest" /> class.
        /// </summary>
        public ApiTasksAnnotationsCreateRequest()
        {
        }
    }
}