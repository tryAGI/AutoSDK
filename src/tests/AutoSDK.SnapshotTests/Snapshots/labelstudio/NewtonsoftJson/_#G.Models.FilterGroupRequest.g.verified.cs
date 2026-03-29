//HintName: G.Models.FilterGroupRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterGroupRequest
    {
        /// <summary>
        /// Type of conjunction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conjunction", Required = global::Newtonsoft.Json.Required.Always)]
        public string Conjunction { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FilterRequest> Filters { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterGroupRequest" /> class.
        /// </summary>
        /// <param name="conjunction">
        /// Type of conjunction
        /// </param>
        /// <param name="filters"></param>
        public FilterGroupRequest(
            string conjunction,
            global::System.Collections.Generic.IList<global::G.FilterRequest> filters)
        {
            this.Conjunction = conjunction ?? throw new global::System.ArgumentNullException(nameof(conjunction));
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterGroupRequest" /> class.
        /// </summary>
        public FilterGroupRequest()
        {
        }
    }
}