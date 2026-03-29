//HintName: G.Models.ModelRegistryItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelRegistryItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public string Author { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contextLength", Required = global::Newtonsoft.Json.Required.Always)]
        public double ContextLength { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoints", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ModelEndpoint> Endpoints { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxOutput")]
        public double? MaxOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trainingDate")]
        public string? TrainingDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputModalities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.InputModality> InputModalities { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputModalities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OutputModality> OutputModalities { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supportedParameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.StandardParameter> SupportedParameters { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pinnedVersionOfModel")]
        public string? PinnedVersionOfModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRegistryItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="author"></param>
        /// <param name="contextLength"></param>
        /// <param name="endpoints"></param>
        /// <param name="inputModalities"></param>
        /// <param name="outputModalities"></param>
        /// <param name="supportedParameters"></param>
        /// <param name="maxOutput"></param>
        /// <param name="trainingDate"></param>
        /// <param name="description"></param>
        /// <param name="pinnedVersionOfModel"></param>
        public ModelRegistryItem(
            string id,
            string name,
            string author,
            double contextLength,
            global::System.Collections.Generic.IList<global::G.ModelEndpoint> endpoints,
            global::System.Collections.Generic.IList<global::G.InputModality> inputModalities,
            global::System.Collections.Generic.IList<global::G.OutputModality> outputModalities,
            global::System.Collections.Generic.IList<global::G.StandardParameter> supportedParameters,
            double? maxOutput,
            string? trainingDate,
            string? description,
            string? pinnedVersionOfModel)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.ContextLength = contextLength;
            this.Endpoints = endpoints ?? throw new global::System.ArgumentNullException(nameof(endpoints));
            this.MaxOutput = maxOutput;
            this.TrainingDate = trainingDate;
            this.Description = description;
            this.InputModalities = inputModalities ?? throw new global::System.ArgumentNullException(nameof(inputModalities));
            this.OutputModalities = outputModalities ?? throw new global::System.ArgumentNullException(nameof(outputModalities));
            this.SupportedParameters = supportedParameters ?? throw new global::System.ArgumentNullException(nameof(supportedParameters));
            this.PinnedVersionOfModel = pinnedVersionOfModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRegistryItem" /> class.
        /// </summary>
        public ModelRegistryItem()
        {
        }
    }
}