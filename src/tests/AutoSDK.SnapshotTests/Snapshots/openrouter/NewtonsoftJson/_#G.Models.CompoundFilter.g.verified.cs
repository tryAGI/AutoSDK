//HintName: G.Models.CompoundFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A compound filter that combines multiple comparison or compound filters
    /// </summary>
    public sealed partial class CompoundFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CompoundFilterTypeJsonConverter))]
        public global::G.CompoundFilterType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Filters { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompoundFilter" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="filters"></param>
        public CompoundFilter(
            global::G.CompoundFilterType type,
            global::System.Collections.Generic.IList<object> filters)
        {
            this.Type = type;
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompoundFilter" /> class.
        /// </summary>
        public CompoundFilter()
        {
        }
    }
}