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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateEvalCompletionsRunDataSourceTypeJsonConverter))]
        public global::G.CreateEvalCompletionsRunDataSourceType Type { get; set; } = global::G.CreateEvalCompletionsRunDataSourceType.Completions;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_messages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.CreateEvalCompletionsRunDataSourceInputMessagesVariant1, global::G.CreateEvalCompletionsRunDataSourceInputMessagesVariant2>))]
        public global::G.OneOf<global::G.CreateEvalCompletionsRunDataSourceInputMessagesVariant1, global::G.CreateEvalCompletionsRunDataSourceInputMessagesVariant2>? InputMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_params")]
        public global::G.CreateEvalCompletionsRunDataSourceSamplingParams? SamplingParams { get; set; }

        /// <summary>
        /// The name of the model to use for generating completions (e.g. "o3-mini").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.EvalJsonlFileContentSource, global::G.EvalJsonlFileIdSource, global::G.EvalStoredCompletionsSource>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.EvalJsonlFileContentSource, global::G.EvalJsonlFileIdSource, global::G.EvalStoredCompletionsSource> Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCompletionsRunDataSource" /> class.
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