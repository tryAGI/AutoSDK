//HintName: G.Models.FineTune.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about a fine-tune
    /// </summary>
    public sealed partial class FineTune
    {
        /// <summary>
        /// Unique identifier for the fine-tune
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the fine-tune
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the fine-tune
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Language code of the fine-tune
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Base model identifier to fine-tune from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// ID of the dataset used for fine-tuning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dataset { get; set; }

        /// <summary>
        /// Status of a fine-tune
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FineTuneStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FineTuneStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTune" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the fine-tune
        /// </param>
        /// <param name="name">
        /// Name of the fine-tune
        /// </param>
        /// <param name="description">
        /// Description of the fine-tune
        /// </param>
        /// <param name="language">
        /// Language code of the fine-tune
        /// </param>
        /// <param name="modelId">
        /// Base model identifier to fine-tune from
        /// </param>
        /// <param name="dataset">
        /// ID of the dataset used for fine-tuning
        /// </param>
        /// <param name="status">
        /// Status of a fine-tune
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTune(
            string id,
            string name,
            string description,
            string language,
            string modelId,
            string dataset,
            global::G.FineTuneStatus status)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Dataset = dataset ?? throw new global::System.ArgumentNullException(nameof(dataset));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTune" /> class.
        /// </summary>
        public FineTune()
        {
        }
    }
}