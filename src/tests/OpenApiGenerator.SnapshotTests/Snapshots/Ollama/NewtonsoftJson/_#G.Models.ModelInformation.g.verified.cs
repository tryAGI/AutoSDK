//HintName: G.Models.ModelInformation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details about a model.
    /// </summary>
    public sealed partial class ModelInformation
    {
        /// <summary>
        /// The architecture of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("general.architecture")]
        public string? General_architecture { get; set; }

        /// <summary>
        /// The file type of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("general.file_type")]
        public int? General_fileType { get; set; }

        /// <summary>
        /// The number of parameters in the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("general.parameter_count")]
        public long? General_parameterCount { get; set; }

        /// <summary>
        /// The number of parameters in the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("general.quantization_version")]
        public int? General_quantizationVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}