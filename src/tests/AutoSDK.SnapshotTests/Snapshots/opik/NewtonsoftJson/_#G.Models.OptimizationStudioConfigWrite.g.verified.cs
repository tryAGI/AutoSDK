//HintName: G.Models.OptimizationStudioConfigWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OptimizationStudioConfigWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StudioPromptWrite Prompt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StudioLlmModelWrite LlmModel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StudioEvaluationWrite Evaluation { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optimizer", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StudioOptimizerWrite Optimizer { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationStudioConfigWrite" /> class.
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="prompt"></param>
        /// <param name="llmModel"></param>
        /// <param name="evaluation"></param>
        /// <param name="optimizer"></param>
        public OptimizationStudioConfigWrite(
            string datasetName,
            global::G.StudioPromptWrite prompt,
            global::G.StudioLlmModelWrite llmModel,
            global::G.StudioEvaluationWrite evaluation,
            global::G.StudioOptimizerWrite optimizer)
        {
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.LlmModel = llmModel ?? throw new global::System.ArgumentNullException(nameof(llmModel));
            this.Evaluation = evaluation ?? throw new global::System.ArgumentNullException(nameof(evaluation));
            this.Optimizer = optimizer ?? throw new global::System.ArgumentNullException(nameof(optimizer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationStudioConfigWrite" /> class.
        /// </summary>
        public OptimizationStudioConfigWrite()
        {
        }
    }
}