//HintName: G.Models.BaseMeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base class for metadata.
    /// </summary>
    public sealed partial class BaseMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public global::G.SummaryMetaField? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMeta" /> class.
        /// </summary>
        /// <param name="summary"></param>
        public BaseMeta(
            global::G.SummaryMetaField? summary)
        {
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMeta" /> class.
        /// </summary>
        public BaseMeta()
        {
        }
    }
}