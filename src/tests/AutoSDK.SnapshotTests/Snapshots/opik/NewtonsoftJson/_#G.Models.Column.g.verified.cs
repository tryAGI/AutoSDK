//HintName: G.Models.Column.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Column
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("types")]
        public global::System.Collections.Generic.IList<global::G.ColumnType>? Types { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter_field_prefix")]
        public string? FilterFieldPrefix { get; set; }

        /// <summary>
        /// The field to use for filtering<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filterField")]
        public string? FilterField { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Column" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="types"></param>
        /// <param name="filterFieldPrefix"></param>
        /// <param name="filterField">
        /// The field to use for filtering<br/>
        /// Included only in responses
        /// </param>
        public Column(
            string? name,
            global::System.Collections.Generic.IList<global::G.ColumnType>? types,
            string? filterFieldPrefix,
            string? filterField)
        {
            this.Name = name;
            this.Types = types;
            this.FilterFieldPrefix = filterFieldPrefix;
            this.FilterField = filterField;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Column" /> class.
        /// </summary>
        public Column()
        {
        }
    }
}