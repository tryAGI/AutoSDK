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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description for the fine-tune
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Language code for the fine-tune
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// Base model ID to fine-tune from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelId { get; set; } = default!;

        /// <summary>
        /// Dataset ID containing training files
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset", Required = global::Newtonsoft.Json.Required.Always)]
        public string Dataset { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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