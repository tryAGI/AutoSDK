//HintName: G.Models.FloatingMeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata model for floating.
    /// </summary>
    public sealed partial class FloatingMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public global::G.SummaryMetaField? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public global::G.DescriptionMetaField? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FloatingMeta" /> class.
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="description"></param>
        public FloatingMeta(
            global::G.SummaryMetaField? summary,
            global::G.DescriptionMetaField? description)
        {
            this.Summary = summary;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FloatingMeta" /> class.
        /// </summary>
        public FloatingMeta()
        {
        }
    }
}