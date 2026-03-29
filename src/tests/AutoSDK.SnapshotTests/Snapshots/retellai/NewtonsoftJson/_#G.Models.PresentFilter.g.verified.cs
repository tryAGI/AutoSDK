//HintName: G.Models.PresentFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PresentFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PresentFilterType Type { get; set; }

        /// <summary>
        /// pr: present (has value), np: not present
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("op", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PresentFilterOp Op { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresentFilter" /> class.
        /// </summary>
        /// <param name="op">
        /// pr: present (has value), np: not present
        /// </param>
        /// <param name="type"></param>
        public PresentFilter(
            global::G.PresentFilterOp op,
            global::G.PresentFilterType type)
        {
            this.Type = type;
            this.Op = op;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresentFilter" /> class.
        /// </summary>
        public PresentFilter()
        {
        }
    }
}