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
        /// The creation date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// the underlying files that make up the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_parts")]
        public global::System.Collections.Generic.IList<global::G.DatasetPart>? DatasetParts { get; set; }

        /// <summary>
        /// The type of the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DatasetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DatasetType DatasetType { get; set; }

        /// <summary>
        /// The dataset ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::G.Metrics? Metrics { get; set; }

        /// <summary>
        /// The name of the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parse_info")]
        public global::G.ParseInfo? ParseInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_fields")]
        public global::System.Collections.Generic.IList<string>? PreserveFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_fields")]
        public global::System.Collections.Generic.IList<string>? RequiredFields { get; set; }

        /// <summary>
        /// the avro schema of the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public string? Schema { get; set; }

        /// <summary>
        /// The last update date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Errors found during validation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_error")]
        public string? ValidationError { get; set; }

        /// <summary>
        /// The validation status of the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DatasetValidationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DatasetValidationStatus ValidationStatus { get; set; }

        /// <summary>
        /// warnings found during validation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_warnings")]
        public global::System.Collections.Generic.IList<string>? ValidationWarnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The creation date
        /// </param>
        /// <param name="datasetParts">
        /// the underlying files that make up the dataset
        /// </param>
        /// <param name="datasetType">
        /// The type of the dataset
        /// </param>
        /// <param name="id">
        /// The dataset ID
        /// </param>
        /// <param name="metrics"></param>
        /// <param name="name">
        /// The name of the dataset
        /// </param>
        /// <param name="parseInfo">
        /// Included only in requests
        /// </param>
        /// <param name="preserveFields"></param>
        /// <param name="requiredFields"></param>
        /// <param name="schema">
        /// the avro schema of the dataset
        /// </param>
        /// <param name="updatedAt">
        /// The last update date
        /// </param>
        /// <param name="validationError">
        /// Errors found during validation
        /// </param>
        /// <param name="validationStatus">
        /// The validation status of the dataset
        /// </param>
        /// <param name="validationWarnings">
        /// warnings found during validation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Dataset(
            global::System.DateTime createdAt,
            global::G.DatasetType datasetType,
            string id,
            string name,
            global::System.DateTime updatedAt,
            global::G.DatasetValidationStatus validationStatus,
            global::System.Collections.Generic.IList<global::G.DatasetPart>? datasetParts,
            global::G.Metrics? metrics,
            global::G.ParseInfo? parseInfo,
            global::System.Collections.Generic.IList<string>? preserveFields,
            global::System.Collections.Generic.IList<string>? requiredFields,
            string? schema,
            string? validationError,
            global::System.Collections.Generic.IList<string>? validationWarnings)
        {
            this.CreatedAt = createdAt;
            this.DatasetType = datasetType;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UpdatedAt = updatedAt;
            this.ValidationStatus = validationStatus;
            this.DatasetParts = datasetParts;
            this.Metrics = metrics;
            this.ParseInfo = parseInfo;
            this.PreserveFields = preserveFields;
            this.RequiredFields = requiredFields;
            this.Schema = schema;
            this.ValidationError = validationError;
            this.ValidationWarnings = validationWarnings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        public Dataset()
        {
        }
    }
}