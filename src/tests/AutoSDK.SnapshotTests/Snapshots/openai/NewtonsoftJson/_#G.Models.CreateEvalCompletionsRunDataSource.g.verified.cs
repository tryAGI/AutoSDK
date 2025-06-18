//HintName: G.Models.CreateEvalCompletionsRunDataSource.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A CompletionsRunDataSource object describing a model sampling configuration.
    /// </summary>
    public sealed partial class CreateEvalCompletionsRunDataSource
    {
        /// <summary>
        /// The type of run data source. Always `completions`.<br/>
        /// Default Value: completions
        /// </summary>
        /// <default>global::G.CreateEvalCompletionsRunDataSourceType.Completions</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateEvalCompletionsRunDataSourceType Type { get; set; } = global::G.CreateEvalCompletionsRunDataSourceType.Completions;

        /// <summary>
        /// Used when sampling from a model. Dictates the structure of the messages passed into the model. Can either be a reference to a prebuilt trajectory (ie, `item.input_trajectory`), or a template with variable references to the `item` namespace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_messages")]
        public global::G.OneOf<global::G.CreateEvalCompletionsRunDataSourceInputMessagesVariant1, global::G.CreateEvalCompletionsRunDataSourceInputMessagesVariant2>? InputMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sampling_params")]
        public global::G.CreateEvalCompletionsRunDataSourceSamplingParams? SamplingParams { get; set; }

        /// <summary>
        /// The name of the model to use for generating completions (e.g. "o3-mini").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Determines what populates the `item` namespace in this run's data source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.EvalJsonlFileContentSource, global::G.EvalJsonlFileIdSource, global::G.EvalStoredCompletionsSource> Source { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSource" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of run data source. Always `completions`.<br/>
        /// Default Value: completions
        /// </param>
        /// <param name="inputMessages">
        /// Used when sampling from a model. Dictates the structure of the messages passed into the model. Can either be a reference to a prebuilt trajectory (ie, `item.input_trajectory`), or a template with variable references to the `item` namespace.
        /// </param>
        /// <param name="samplingParams"></param>
        /// <param name="model">
        /// The name of the model to use for generating completions (e.g. "o3-mini").
        /// </param>
        /// <param name="source">
        /// Determines what populates the `item` namespace in this run's data source.
        /// </param>
        public CreateEvalCompletionsRunDataSource(
            global::G.OneOf<global::G.EvalJsonlFileContentSource, global::G.EvalJsonlFileIdSource, global::G.EvalStoredCompletionsSource> source,
            global::G.OneOf<global::G.CreateEvalCompletionsRunDataSourceInputMessagesVariant1, global::G.CreateEvalCompletionsRunDataSourceInputMessagesVariant2>? inputMessages,
            global::G.CreateEvalCompletionsRunDataSourceSamplingParams? samplingParams,
            string? model,
            global::G.CreateEvalCompletionsRunDataSourceType type = global::G.CreateEvalCompletionsRunDataSourceType.Completions)
        {
            this.Source = source;
            this.Type = type;
            this.InputMessages = inputMessages;
            this.SamplingParams = samplingParams;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSource" /> class.
        /// </summary>
        public CreateEvalCompletionsRunDataSource()
        {
        }
    }
}