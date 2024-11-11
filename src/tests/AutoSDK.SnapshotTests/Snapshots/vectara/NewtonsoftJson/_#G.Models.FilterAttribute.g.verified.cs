//HintName: G.Models.FilterAttribute.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterAttribute
    {
        /// <summary>
        /// The JSON path of the filter attribute in a document or document part metadata.<br/>
        /// Example: Title
        /// </summary>
        /// <example>Title</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Indicates whether this is a document or document part metadata filter.<br/>
        /// Example: document
        /// </summary>
        /// <example>document</example>
        [global::Newtonsoft.Json.JsonProperty("level", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FilterAttributeLevel Level { get; set; } = default!;

        /// <summary>
        /// Description of the filter. May be omitted.<br/>
        /// Example: The title of the document.
        /// </summary>
        /// <example>The title of the document.</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether an index should be created for the filter. Creating an index will improve query latency when using the filter.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexed")]
        public bool? Indexed { get; set; }

        /// <summary>
        /// The value type of the filter.<br/>
        /// Example: text
        /// </summary>
        /// <example>text</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FilterAttributeType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterAttribute" /> class.
        /// </summary>
        /// <param name="name">
        /// The JSON path of the filter attribute in a document or document part metadata.<br/>
        /// Example: Title
        /// </param>
        /// <param name="level">
        /// Indicates whether this is a document or document part metadata filter.<br/>
        /// Example: document
        /// </param>
        /// <param name="description">
        /// Description of the filter. May be omitted.<br/>
        /// Example: The title of the document.
        /// </param>
        /// <param name="indexed">
        /// Indicates whether an index should be created for the filter. Creating an index will improve query latency when using the filter.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="type">
        /// The value type of the filter.<br/>
        /// Example: text
        /// </param>
        public FilterAttribute(
            string name,
            global::G.FilterAttributeLevel level,
            global::G.FilterAttributeType type,
            string? description,
            bool? indexed)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Level = level;
            this.Type = type;
            this.Description = description;
            this.Indexed = indexed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterAttribute" /> class.
        /// </summary>
        public FilterAttribute()
        {
        }
    }
}