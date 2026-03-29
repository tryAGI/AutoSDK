//HintName: G.Models.OpenAIChatCompletion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OpenAI-compatible chat completion response.
    /// </summary>
    public sealed partial class OpenAIChatCompletion
    {
        /// <summary>
        /// The id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The created date
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created", Required = global::Newtonsoft.Json.Required.Always)]
        public string Created { get; set; } = default!;

        /// <summary>
        /// The model name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelName { get; set; } = default!;

        /// <summary>
        /// The completion choices
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OpenAIChatCompletionChoice> Choices { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatCompletion" /> class.
        /// </summary>
        /// <param name="id">
        /// The id
        /// </param>
        /// <param name="created">
        /// The created date
        /// </param>
        /// <param name="modelName">
        /// The model name
        /// </param>
        /// <param name="choices">
        /// The completion choices
        /// </param>
        public OpenAIChatCompletion(
            string id,
            string created,
            string modelName,
            global::System.Collections.Generic.IList<global::G.OpenAIChatCompletionChoice> choices)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Created = created ?? throw new global::System.ArgumentNullException(nameof(created));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatCompletion" /> class.
        /// </summary>
        public OpenAIChatCompletion()
        {
        }
    }
}