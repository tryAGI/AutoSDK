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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Default Value: model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public int? Created { get; set; }

        /// <summary>
        /// Default Value: mistralai
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owned_by")]
        public string? OwnedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("capabilities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelCapabilities Capabilities { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default Value: 32768
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_context_length")]
        public int? MaxContextLength { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aliases")]
        public global::System.Collections.Generic.IList<string>? Aliases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deprecation")]
        public global::System.DateTime? Deprecation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_model_temperature")]
        public double? DefaultModelTemperature { get; set; }

        /// <summary>
        /// Default Value: fine-tuned
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.FTModelCardType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job", Required = global::Newtonsoft.Json.Required.Always)]
        public string Job { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("root", Required = global::Newtonsoft.Json.Required.Always)]
        public string Root { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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