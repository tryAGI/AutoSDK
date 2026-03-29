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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The created date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Created { get; set; }

        /// <summary>
        /// The model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// The completion choices
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OpenAIChatCompletionChoice> Choices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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