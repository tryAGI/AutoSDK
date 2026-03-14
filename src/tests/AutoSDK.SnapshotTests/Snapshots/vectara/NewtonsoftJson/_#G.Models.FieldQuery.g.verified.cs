//HintName: G.Models.FieldQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines a field-specific query for fuzzy matching.
    /// </summary>
    public sealed partial class FieldQuery
    {
        /// <summary>
        /// Name of the metadata field to search (without doc/part prefix).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field", Required = global::Newtonsoft.Json.Required.Always)]
        public string Field { get; set; } = default!;

        /// <summary>
        /// The text to search for in this field. Fuzzy matching is applied automatically.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// Weight to apply to this field during scoring (higher values increase importance of this field).<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weight")]
        public float? Weight { get; set; }

        /// <summary>
        /// Whether to apply fuzzy matching for typo tolerance.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fuzzy")]
        public bool? Fuzzy { get; set; }

        /// <summary>
        /// Minimum query length to enable prefix matching. Set to null to disable prefix matching. Prefix matching allows finding documents where the field value starts with the query text.<br/>
        /// Default Value: 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefix")]
        public int? Prefix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldQuery" /> class.
        /// </summary>
        /// <param name="field">
        /// Name of the metadata field to search (without doc/part prefix).
        /// </param>
        /// <param name="query">
        /// The text to search for in this field. Fuzzy matching is applied automatically.
        /// </param>
        /// <param name="weight">
        /// Weight to apply to this field during scoring (higher values increase importance of this field).<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="fuzzy">
        /// Whether to apply fuzzy matching for typo tolerance.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="prefix">
        /// Minimum query length to enable prefix matching. Set to null to disable prefix matching. Prefix matching allows finding documents where the field value starts with the query text.<br/>
        /// Default Value: 3
        /// </param>
        public FieldQuery(
            string field,
            string query,
            float? weight,
            bool? fuzzy,
            int? prefix)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Weight = weight;
            this.Fuzzy = fuzzy;
            this.Prefix = prefix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldQuery" /> class.
        /// </summary>
        public FieldQuery()
        {
        }
    }
}