//HintName: G.Models.RunGraderRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunGraderRequest
    {
        /// <summary>
        /// The grader used for the fine-tuning job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("grader", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.GraderStringCheck, global::G.GraderTextSimilarity, global::G.GraderPython, global::G.GraderScoreModel, global::G.GraderMulti> Grader { get; set; } = default!;

        /// <summary>
        /// The dataset item provided to the grader. This will be used to populate <br/>
        /// the `item` namespace. See [the guide](/docs/guides/graders) for more details. 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item")]
        public object? Item { get; set; }

        /// <summary>
        /// The model sample to be evaluated. This value will be used to populate <br/>
        /// the `sample` namespace. See [the guide](/docs/guides/graders) for more details.<br/>
        /// The `output_json` variable will be populated if the model sample is a <br/>
        /// valid JSON string.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_sample", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelSample { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGraderRequest" /> class.
        /// </summary>
        /// <param name="grader">
        /// The grader used for the fine-tuning job.
        /// </param>
        /// <param name="item">
        /// The dataset item provided to the grader. This will be used to populate <br/>
        /// the `item` namespace. See [the guide](/docs/guides/graders) for more details. 
        /// </param>
        /// <param name="modelSample">
        /// The model sample to be evaluated. This value will be used to populate <br/>
        /// the `sample` namespace. See [the guide](/docs/guides/graders) for more details.<br/>
        /// The `output_json` variable will be populated if the model sample is a <br/>
        /// valid JSON string.
        /// </param>
        public RunGraderRequest(
            global::G.OneOf<global::G.GraderStringCheck, global::G.GraderTextSimilarity, global::G.GraderPython, global::G.GraderScoreModel, global::G.GraderMulti> grader,
            string modelSample,
            object? item)
        {
            this.Grader = grader;
            this.ModelSample = modelSample ?? throw new global::System.ArgumentNullException(nameof(modelSample));
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunGraderRequest" /> class.
        /// </summary>
        public RunGraderRequest()
        {
        }
    }
}