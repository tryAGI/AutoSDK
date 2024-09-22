//HintName: G.Models.Dataset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Dataset
    {
        /// <summary>
        /// The dataset ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The name of the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The creation date
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The last update date
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The type of the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DatasetType DatasetType { get; set; } = default!;

        /// <summary>
        /// The validation status of the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validation_status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DatasetValidationStatus ValidationStatus { get; set; } = default!;

        /// <summary>
        /// Errors found during validation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validation_error")]
        public string? ValidationError { get; set; }

        /// <summary>
        /// the avro schema of the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema")]
        public string? Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_fields")]
        public global::System.Collections.Generic.IList<string>? RequiredFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preserve_fields")]
        public global::System.Collections.Generic.IList<string>? PreserveFields { get; set; }

        /// <summary>
        /// the underlying files that make up the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_parts")]
        public global::System.Collections.Generic.IList<global::G.DatasetPart>? DatasetParts { get; set; }

        /// <summary>
        /// warnings found during validation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validation_warnings")]
        public global::System.Collections.Generic.IList<string>? ValidationWarnings { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parse_info")]
        public global::G.ParseInfo? ParseInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metrics")]
        public global::G.Metrics? Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}