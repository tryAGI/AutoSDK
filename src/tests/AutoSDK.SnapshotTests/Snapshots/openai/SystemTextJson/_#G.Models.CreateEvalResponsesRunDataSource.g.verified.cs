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
        /// The type of run data source. Always `completions`.<br/>
        /// Default Value: completions
        /// </summary>
        /// <default>global::G.CreateEvalResponsesRunDataSourceType.Completions</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateEvalResponsesRunDataSourceTypeJsonConverter))]
        public global::G.CreateEvalResponsesRunDataSourceType Type { get; set; } = global::G.CreateEvalResponsesRunDataSourceType.Completions;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_messages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.CreateEvalResponsesRunDataSourceInputMessagesVariant1, global::G.CreateEvalResponsesRunDataSourceInputMessagesVariant2>))]
        public global::G.OneOf<global::G.CreateEvalResponsesRunDataSourceInputMessagesVariant1, global::G.CreateEvalResponsesRunDataSourceInputMessagesVariant2>? InputMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_params")]
        public global::G.CreateEvalResponsesRunDataSourceSamplingParams? SamplingParams { get; set; }

        /// <summary>
        /// The name of the model to use for generating completions (e.g. "o3-mini").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.EvalJsonlFileContentSource, global::G.EvalJsonlFileIdSource, global::G.EvalResponsesSource>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.EvalJsonlFileContentSource, global::G.EvalJsonlFileIdSource, global::G.EvalResponsesSource> Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalResponsesRunDataSource" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of run data source. Always `completions`.<br/>
        /// Default Value: completions
        /// </param>
        /// <param name="inputMessages"></param>
        /// <param name="samplingParams"></param>
        /// <param name="model">
        /// The name of the model to use for generating completions (e.g. "o3-mini").
        /// </param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvalResponsesRunDataSource(
            global::G.OneOf<global::G.EvalJsonlFileContentSource, global::G.EvalJsonlFileIdSource, global::G.EvalResponsesSource> source,
            global::G.OneOf<global::G.CreateEvalResponsesRunDataSourceInputMessagesVariant1, global::G.CreateEvalResponsesRunDataSourceInputMessagesVariant2>? inputMessages,
            global::G.CreateEvalResponsesRunDataSourceSamplingParams? samplingParams,
            string? model,
            global::G.CreateEvalResponsesRunDataSourceType type = global::G.CreateEvalResponsesRunDataSourceType.Completions)
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