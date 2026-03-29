//HintName: G.Models.CreateFineTuneRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create a new fine-tune
    /// </summary>
    public sealed partial class CreateFineTuneRequest
    {
        /// <summary>
        /// Name for the new fine-tune
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description for the fine-tune
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Language code for the fine-tune
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Base model ID to fine-tune from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Dataset ID containing training files
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dataset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFineTuneRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the new fine-tune
        /// </param>
        /// <param name="description">
        /// Description for the fine-tune
        /// </param>
        /// <param name="language">
        /// Language code for the fine-tune
        /// </param>
        /// <param name="modelId">
        /// Base model ID to fine-tune from
        /// </param>
        /// <param name="dataset">
        /// Dataset ID containing training files
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFineTuneRequest(
            string name,
            string description,
            string language,
            string modelId,
            string dataset)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Dataset = dataset ?? throw new global::System.ArgumentNullException(nameof(dataset));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFineTuneRequest" /> class.
        /// </summary>
        public CreateFineTuneRequest()
        {
        }
    }
}