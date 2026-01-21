//HintName: G.Models.ClassifierFTModelOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifierFTModelOut
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
        public global::G.ClassifierFTModelOutObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created", Required = global::Newtonsoft.Json.Required.Always)]
        public int Created { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owned_by", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnedBy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("root", Required = global::Newtonsoft.Json.Required.Always)]
        public string Root { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Archived { get; set; } = default!;

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("capabilities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FTModelCapabilitiesOut Capabilities { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("job", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Job { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classifier_targets", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ClassifierTargetOut> ClassifierTargets { get; set; } = default!;

        /// <summary>
        /// Default Value: classifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_type")]
        public global::G.ClassifierFTModelOutModelType? ModelType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierFTModelOut" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="object">
        /// Default Value: model
        /// </param>
        /// <param name="created"></param>
        /// <param name="ownedBy"></param>
        /// <param name="root"></param>
        /// <param name="archived"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="capabilities"></param>
        /// <param name="maxContextLength">
        /// Default Value: 32768
        /// </param>
        /// <param name="aliases">
        /// Default Value: []
        /// </param>
        /// <param name="job"></param>
        /// <param name="classifierTargets"></param>
        /// <param name="modelType">
        /// Default Value: classifier
        /// </param>
        public ClassifierFTModelOut(
            string id,
            int created,
            string ownedBy,
            string root,
            bool archived,
            global::G.FTModelCapabilitiesOut capabilities,
            global::System.Guid job,
            global::System.Collections.Generic.IList<global::G.ClassifierTargetOut> classifierTargets,
            global::G.ClassifierFTModelOutObject? @object,
            string? name,
            string? description,
            int? maxContextLength,
            global::System.Collections.Generic.IList<string>? aliases,
            global::G.ClassifierFTModelOutModelType? modelType)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Created = created;
            this.OwnedBy = ownedBy ?? throw new global::System.ArgumentNullException(nameof(ownedBy));
            this.Root = root ?? throw new global::System.ArgumentNullException(nameof(root));
            this.Archived = archived;
            this.Capabilities = capabilities ?? throw new global::System.ArgumentNullException(nameof(capabilities));
            this.Job = job;
            this.ClassifierTargets = classifierTargets ?? throw new global::System.ArgumentNullException(nameof(classifierTargets));
            this.Object = @object;
            this.Name = name;
            this.Description = description;
            this.MaxContextLength = maxContextLength;
            this.Aliases = aliases;
            this.ModelType = modelType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierFTModelOut" /> class.
        /// </summary>
        public ClassifierFTModelOut()
        {
        }
    }
}