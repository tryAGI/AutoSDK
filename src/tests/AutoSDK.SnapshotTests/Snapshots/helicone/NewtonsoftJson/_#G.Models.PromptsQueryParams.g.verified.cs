//HintName: G.Models.PromptsQueryParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptsQueryParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptsFilterNode Filter { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptsQueryParams" /> class.
        /// </summary>
        /// <param name="filter"></param>
        public PromptsQueryParams(
            global::G.PromptsFilterNode filter)
        {
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptsQueryParams" /> class.
        /// </summary>
        public PromptsQueryParams()
        {
        }
    }
}