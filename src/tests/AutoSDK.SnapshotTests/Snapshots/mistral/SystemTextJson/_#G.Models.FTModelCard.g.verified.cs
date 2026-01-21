//HintName: G.Models.FTModelCard.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Extra fields for fine-tuned models.
    /// </summary>
    public sealed partial class FTModelCard
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// Default Value: mistralai
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owned_by")]
        public string? OwnedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelCapabilities Capabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default Value: 32768
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_context_length")]
        public int? MaxContextLength { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        public global::System.Collections.Generic.IList<string>? Aliases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecation")]
        public global::System.DateTime? Deprecation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_model_temperature")]
        public double? DefaultModelTemperature { get; set; }

        /// <summary>
        /// Default Value: fine-tuned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FTModelCardTypeJsonConverter))]
        public global::G.FTModelCardType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Job { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Root { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FTModelCard" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="object">
        /// Default Value: model
        /// </param>
        /// <param name="created"></param>
        /// <param name="ownedBy">
        /// Default Value: mistralai
        /// </param>
        /// <param name="capabilities"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="maxContextLength">
        /// Default Value: 32768
        /// </param>
        /// <param name="aliases">
        /// Default Value: []
        /// </param>
        /// <param name="deprecation"></param>
        /// <param name="defaultModelTemperature"></param>
        /// <param name="type">
        /// Default Value: fine-tuned
        /// </param>
        /// <param name="job"></param>
        /// <param name="root"></param>
        /// <param name="archived">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FTModelCard(
            string id,
            global::G.ModelCapabilities capabilities,
            string job,
            string root,
            string? @object,
            int? created,
            string? ownedBy,
            string? name,
            string? description,
            int? maxContextLength,
            global::System.Collections.Generic.IList<string>? aliases,
            global::System.DateTime? deprecation,
            double? defaultModelTemperature,
            global::G.FTModelCardType? type,
            bool? archived)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Capabilities = capabilities ?? throw new global::System.ArgumentNullException(nameof(capabilities));
            this.Job = job ?? throw new global::System.ArgumentNullException(nameof(job));
            this.Root = root ?? throw new global::System.ArgumentNullException(nameof(root));
            this.Object = @object;
            this.Created = created;
            this.OwnedBy = ownedBy;
            this.Name = name;
            this.Description = description;
            this.MaxContextLength = maxContextLength;
            this.Aliases = aliases;
            this.Deprecation = deprecation;
            this.DefaultModelTemperature = defaultModelTemperature;
            this.Type = type;
            this.Archived = archived;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FTModelCard" /> class.
        /// </summary>
        public FTModelCard()
        {
        }
    }
}