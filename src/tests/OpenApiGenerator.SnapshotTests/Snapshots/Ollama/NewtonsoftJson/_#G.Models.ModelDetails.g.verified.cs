//HintName: G.Models.ModelDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details about a model.
    /// </summary>
    public sealed partial class ModelDetails
    {
        /// <summary>
        /// The parent model of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_model")]
        public string? ParentModel { get; set; }

        /// <summary>
        /// The format of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public string? Format { get; set; }

        /// <summary>
        /// The family of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("family")]
        public string? Family { get; set; }

        /// <summary>
        /// The families of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("families")]
        public global::System.Collections.Generic.IList<string>? Families { get; set; }

        /// <summary>
        /// The size of the model's parameters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameter_size")]
        public string? ParameterSize { get; set; }

        /// <summary>
        /// The quantization level of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quantization_level")]
        public string? QuantizationLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}