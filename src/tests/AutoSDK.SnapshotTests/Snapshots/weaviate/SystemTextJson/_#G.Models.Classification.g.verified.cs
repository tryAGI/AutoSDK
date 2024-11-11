//HintName: G.Models.Classification.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Manage classifications, trigger them and view status of past classifications.
    /// </summary>
    public sealed partial class Classification
    {
        /// <summary>
        /// ID to uniquely identify this classification run<br/>
        /// Example: ee722219-b8ec-4db1-8f8d-5150bb1a9e0c
        /// </summary>
        /// <example>ee722219-b8ec-4db1-8f8d-5150bb1a9e0c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// class (name) which is used in this classification<br/>
        /// Example: City
        /// </summary>
        /// <example>City</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("class")]
        public string? Class { get; set; }

        /// <summary>
        /// which ref-property to set as part of the classification<br/>
        /// Example: [inCountry]
        /// </summary>
        /// <example>[inCountry]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifyProperties")]
        public global::System.Collections.Generic.IList<string>? ClassifyProperties { get; set; }

        /// <summary>
        /// base the text-based classification on these fields (of type text)<br/>
        /// Example: [description]
        /// </summary>
        /// <example>[description]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("basedOnProperties")]
        public global::System.Collections.Generic.IList<string>? BasedOnProperties { get; set; }

        /// <summary>
        /// status of this classification<br/>
        /// Example: running
        /// </summary>
        /// <example>running</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClassificationStatusJsonConverter))]
        public global::G.ClassificationStatus? Status { get; set; }

        /// <summary>
        /// Additional information to a specific classification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::G.ClassificationMeta? Meta { get; set; }

        /// <summary>
        /// which algorithm to use for classifications
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// classification-type specific settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public object? Settings { get; set; }

        /// <summary>
        /// error message if status == failed<br/>
        /// Example: classify xzy: something went wrong
        /// </summary>
        /// <example>classify xzy: something went wrong</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::G.ClassificationFilters? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Classification" /> class.
        /// </summary>
        /// <param name="id">
        /// ID to uniquely identify this classification run<br/>
        /// Example: ee722219-b8ec-4db1-8f8d-5150bb1a9e0c
        /// </param>
        /// <param name="class">
        /// class (name) which is used in this classification<br/>
        /// Example: City
        /// </param>
        /// <param name="classifyProperties">
        /// which ref-property to set as part of the classification<br/>
        /// Example: [inCountry]
        /// </param>
        /// <param name="basedOnProperties">
        /// base the text-based classification on these fields (of type text)<br/>
        /// Example: [description]
        /// </param>
        /// <param name="status">
        /// status of this classification<br/>
        /// Example: running
        /// </param>
        /// <param name="meta">
        /// Additional information to a specific classification
        /// </param>
        /// <param name="type">
        /// which algorithm to use for classifications
        /// </param>
        /// <param name="settings">
        /// classification-type specific settings
        /// </param>
        /// <param name="error">
        /// error message if status == failed<br/>
        /// Example: classify xzy: something went wrong
        /// </param>
        /// <param name="filters"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Classification(
            global::System.Guid? id,
            string? @class,
            global::System.Collections.Generic.IList<string>? classifyProperties,
            global::System.Collections.Generic.IList<string>? basedOnProperties,
            global::G.ClassificationStatus? status,
            global::G.ClassificationMeta? meta,
            string? type,
            object? settings,
            string? error,
            global::G.ClassificationFilters? filters)
        {
            this.Id = id;
            this.Class = @class;
            this.ClassifyProperties = classifyProperties;
            this.BasedOnProperties = basedOnProperties;
            this.Status = status;
            this.Meta = meta;
            this.Type = type;
            this.Settings = settings;
            this.Error = error;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Classification" /> class.
        /// </summary>
        public Classification()
        {
        }
    }
}