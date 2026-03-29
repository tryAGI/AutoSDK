//HintName: G.Models.DeleteCollectionRecordsPayloadVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteCollectionRecordsPayloadVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ids")]
        public global::System.Collections.Generic.IList<string>? Ids { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCollectionRecordsPayloadVariant2" /> class.
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="limit"></param>
        public DeleteCollectionRecordsPayloadVariant2(
            global::System.Collections.Generic.IList<string>? ids,
            int? limit)
        {
            this.Ids = ids;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCollectionRecordsPayloadVariant2" /> class.
        /// </summary>
        public DeleteCollectionRecordsPayloadVariant2()
        {
        }
    }
}