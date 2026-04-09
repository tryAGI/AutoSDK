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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the fine-tune
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the fine-tune
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Language code of the fine-tune
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// Base model identifier to fine-tune from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelId { get; set; } = default!;

        /// <summary>
        /// ID of the dataset used for fine-tuning
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset", Required = global::Newtonsoft.Json.Required.Always)]
        public string Dataset { get; set; } = default!;

        /// <summary>
        /// Status of a fine-tune
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FineTuneStatusJsonConverter))]
        public global::G.FineTuneStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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