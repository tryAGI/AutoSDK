//HintName: G.Models.Filter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Filter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("child_filter")]
        public global::G.ChildFilter? ChildFilter { get; set; }

        /// <summary>
        /// Field name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column", Required = global::Newtonsoft.Json.Required.Always)]
        public string Column { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Display order among root filters only
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Filter operator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        public string Operator { get; set; } = default!;

        /// <summary>
        /// Optional parent filter to create one-level hierarchy (child filters are AND-merged with parent)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent")]
        public int? Parent { get; set; }

        /// <summary>
        /// Field type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Filter value
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter" /> class.
        /// </summary>
        /// <param name="column">
        /// Field name
        /// </param>
        /// <param name="operator">
        /// Filter operator
        /// </param>
        /// <param name="type">
        /// Field type
        /// </param>
        /// <param name="childFilter"></param>
        /// <param name="index">
        /// Display order among root filters only
        /// </param>
        /// <param name="parent">
        /// Optional parent filter to create one-level hierarchy (child filters are AND-merged with parent)
        /// </param>
        /// <param name="value">
        /// Filter value
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        public Filter(
            string column,
            string @operator,
            string type,
            global::G.ChildFilter? childFilter,
            int? index,
            int? parent,
            object? value,
            int id = default!)
        {
            this.ChildFilter = childFilter;
            this.Column = column ?? throw new global::System.ArgumentNullException(nameof(column));
            this.Id = id;
            this.Index = index;
            this.Operator = @operator ?? throw new global::System.ArgumentNullException(nameof(@operator));
            this.Parent = parent;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter" /> class.
        /// </summary>
        public Filter()
        {
        }
    }
}