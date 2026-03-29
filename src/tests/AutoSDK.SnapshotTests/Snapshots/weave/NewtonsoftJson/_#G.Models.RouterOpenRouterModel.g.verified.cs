//HintName: G.Models.RouterOpenRouterModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RouterOpenRouterModel
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
        [global::Newtonsoft.Json.JsonProperty("created", Required = global::Newtonsoft.Json.Required.Always)]
        public int Created { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_modalities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> InputModalities { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_modalities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> OutputModalities { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quantization", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RouterOpenRouterModelQuantization Quantization { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context_length", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContextLength { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_output_length", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxOutputLength { get; set; } = default!;

        /// <summary>
        /// All pricing values are in USD per 1 token.<br/>
        /// Pricing fields are in string format to avoid floating point precision issues.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pricing", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Pricing Pricing { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supported_sampling_parameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RouterOpenRouterModelSupportedSamplingParameter> SupportedSamplingParameters { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supported_features", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RouterOpenRouterModelSupportedFeature> SupportedFeatures { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datacenters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Datacenter> Datacenters { get; set; } = default!;

        /// <summary>
        /// Date when the model is deprecated (YYYY-MM-DD). Omitted from output if not set.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deprecation_date")]
        public string? DeprecationDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouterOpenRouterModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="created"></param>
        /// <param name="inputModalities"></param>
        /// <param name="outputModalities"></param>
        /// <param name="quantization"></param>
        /// <param name="contextLength"></param>
        /// <param name="maxOutputLength"></param>
        /// <param name="pricing">
        /// All pricing values are in USD per 1 token.<br/>
        /// Pricing fields are in string format to avoid floating point precision issues.
        /// </param>
        /// <param name="supportedSamplingParameters"></param>
        /// <param name="supportedFeatures"></param>
        /// <param name="datacenters"></param>
        /// <param name="deprecationDate">
        /// Date when the model is deprecated (YYYY-MM-DD). Omitted from output if not set.
        /// </param>
        public RouterOpenRouterModel(
            string id,
            string name,
            int created,
            global::System.Collections.Generic.IList<string> inputModalities,
            global::System.Collections.Generic.IList<string> outputModalities,
            global::G.RouterOpenRouterModelQuantization quantization,
            int contextLength,
            int maxOutputLength,
            global::G.Pricing pricing,
            global::System.Collections.Generic.IList<global::G.RouterOpenRouterModelSupportedSamplingParameter> supportedSamplingParameters,
            global::System.Collections.Generic.IList<global::G.RouterOpenRouterModelSupportedFeature> supportedFeatures,
            global::System.Collections.Generic.IList<global::G.Datacenter> datacenters,
            string? deprecationDate)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Created = created;
            this.InputModalities = inputModalities ?? throw new global::System.ArgumentNullException(nameof(inputModalities));
            this.OutputModalities = outputModalities ?? throw new global::System.ArgumentNullException(nameof(outputModalities));
            this.Quantization = quantization;
            this.ContextLength = contextLength;
            this.MaxOutputLength = maxOutputLength;
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.SupportedSamplingParameters = supportedSamplingParameters ?? throw new global::System.ArgumentNullException(nameof(supportedSamplingParameters));
            this.SupportedFeatures = supportedFeatures ?? throw new global::System.ArgumentNullException(nameof(supportedFeatures));
            this.Datacenters = datacenters ?? throw new global::System.ArgumentNullException(nameof(datacenters));
            this.DeprecationDate = deprecationDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouterOpenRouterModel" /> class.
        /// </summary>
        public RouterOpenRouterModel()
        {
        }
    }
}