//HintName: G.Models.CreateEvalResponsesRunDataSource.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A ResponsesRunDataSource object describing a model sampling configuration.
    /// </summary>
    public sealed partial class CreateEvalResponsesRunDataSource
    {
        /// <summary>
        /// The type of run data source. Always `responses`.<br/>
        /// Default Value: responses
        /// </summary>
        /// <default>global::G.CreateEvalResponsesRunDataSourceType.Responses</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateEvalResponsesRunDataSourceType Type { get; set; } = global::G.CreateEvalResponsesRunDataSourceType.Responses;

        /// <summary>
        /// Used when sampling from a model. Dictates the structure of the messages passed into the model. Can either be a reference to a prebuilt trajectory (ie, `item.input_trajectory`), or a template with variable references to the `item` namespace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_messages")]
        public global::G.OneOf<global::G.CreateEvalResponsesRunDataSourceInputMessagesVariant1, global::G.CreateEvalResponsesRunDataSourceInputMessagesVariant2>? InputMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sampling_params")]
        public global::G.CreateEvalResponsesRunDataSourceSamplingParams? SamplingParams { get; set; }

        /// <summary>
        /// The name of the model to use for generating completions (e.g. "o3-mini").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Determines what populates the `item` namespace in this run's data source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.EvalJsonlFileContentSource, global::G.EvalJsonlFileIdSource, global::G.EvalResponsesSource> Source { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalResponsesRunDataSource" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of run data source. Always `responses`.<br/>
        /// Default Value: responses
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
        public CreateEvalResponsesRunDataSource(
            global::G.OneOf<global::G.EvalJsonlFileContentSource, global::G.EvalJsonlFileIdSource, global::G.EvalResponsesSource> source,
            global::G.OneOf<global::G.CreateEvalResponsesRunDataSourceInputMessagesVariant1, global::G.CreateEvalResponsesRunDataSourceInputMessagesVariant2>? inputMessages,
            global::G.CreateEvalResponsesRunDataSourceSamplingParams? samplingParams,
            string? model,
            global::G.CreateEvalResponsesRunDataSourceType type = global::G.CreateEvalResponsesRunDataSourceType.Responses)
        {
            this.Source = source;
            this.Type = type;
            this.InputMessages = inputMessages;
            this.SamplingParams = samplingParams;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalResponsesRunDataSource" /> class.
        /// </summary>
        public CreateEvalResponsesRunDataSource()
        {
        }
    }
}