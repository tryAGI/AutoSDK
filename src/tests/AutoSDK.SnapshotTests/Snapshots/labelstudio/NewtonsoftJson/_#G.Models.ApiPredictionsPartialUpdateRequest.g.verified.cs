//HintName: G.Models.ApiPredictionsPartialUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"model_version":"yolo-v8","result":[{"from_name":"bboxes","image_rotation":0,"original_height":1080,"original_width":1920,"to_name":"image","type":"rectanglelabels","value":{"height":60,"rotation":0,"values":{"rectanglelabels":["Person"]},"width":50,"x":20,"y":30}}],"score":0.95}
    /// </summary>
    public sealed partial class ApiPredictionsPartialUpdateRequest
    {
        /// <summary>
        /// Model version - tag for predictions that can be used to filter tasks in Data Manager, as well as select specific model version for showing preannotations in the labeling interface<br/>
        /// Example: yolo-v8
        /// </summary>
        /// <example>yolo-v8</example>
        [global::Newtonsoft.Json.JsonProperty("model_version")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// Prediction result in JSON format. Read more about the format in [the Label Studio documentation.](https://labelstud.io/guide/predictions)<br/>
        /// Example: [{"from_name":"bboxes","image_rotation":0,"original_height":1080,"original_width":1920,"to_name":"image","type":"rectanglelabels","value":{"height":60,"rotation":0,"values":{"rectanglelabels":["Person"]},"width":50,"x":20,"y":30}}]
        /// </summary>
        /// <example>[{"from_name":"bboxes","image_rotation":0,"original_height":1080,"original_width":1920,"to_name":"image","type":"rectanglelabels","value":{"height":60,"rotation":0,"values":{"rectanglelabels":["Person"]},"width":50,"x":20,"y":30}}]</example>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::System.Collections.Generic.IList<object>? Result { get; set; }

        /// <summary>
        /// Prediction score. Can be used in Data Manager to sort task by model confidence. Task with the lowest score will be shown first.<br/>
        /// Example: 0.95
        /// </summary>
        /// <example>0.95</example>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Task ID for which the prediction is created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task")]
        public int? Task { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiPredictionsPartialUpdateRequest" /> class.
        /// </summary>
        /// <param name="modelVersion">
        /// Model version - tag for predictions that can be used to filter tasks in Data Manager, as well as select specific model version for showing preannotations in the labeling interface<br/>
        /// Example: yolo-v8
        /// </param>
        /// <param name="result">
        /// Prediction result in JSON format. Read more about the format in [the Label Studio documentation.](https://labelstud.io/guide/predictions)<br/>
        /// Example: [{"from_name":"bboxes","image_rotation":0,"original_height":1080,"original_width":1920,"to_name":"image","type":"rectanglelabels","value":{"height":60,"rotation":0,"values":{"rectanglelabels":["Person"]},"width":50,"x":20,"y":30}}]
        /// </param>
        /// <param name="score">
        /// Prediction score. Can be used in Data Manager to sort task by model confidence. Task with the lowest score will be shown first.<br/>
        /// Example: 0.95
        /// </param>
        /// <param name="task">
        /// Task ID for which the prediction is created
        /// </param>
        public ApiPredictionsPartialUpdateRequest(
            string? modelVersion,
            global::System.Collections.Generic.IList<object>? result,
            double? score,
            int? task)
        {
            this.ModelVersion = modelVersion;
            this.Result = result;
            this.Score = score;
            this.Task = task;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiPredictionsPartialUpdateRequest" /> class.
        /// </summary>
        public ApiPredictionsPartialUpdateRequest()
        {
        }
    }
}