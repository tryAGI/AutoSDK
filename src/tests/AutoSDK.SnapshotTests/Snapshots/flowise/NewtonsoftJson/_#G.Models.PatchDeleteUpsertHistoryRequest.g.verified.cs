//HintName: G.Models.PatchDeleteUpsertHistoryRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchDeleteUpsertHistoryRequest
    {
        /// <summary>
        /// List of upsert history record IDs to delete
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Ids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchDeleteUpsertHistoryRequest" /> class.
        /// </summary>
        /// <param name="ids">
        /// List of upsert history record IDs to delete
        /// </param>
        public PatchDeleteUpsertHistoryRequest(
            global::System.Collections.Generic.IList<global::System.Guid>? ids)
        {
            this.Ids = ids;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchDeleteUpsertHistoryRequest" /> class.
        /// </summary>
        public PatchDeleteUpsertHistoryRequest()
        {
        }
    }
}