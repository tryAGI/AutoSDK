//HintName: G.Models.CustomerInsertResp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomerInsertResp
    {
        /// <summary>
        /// The number of inserted entities.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("insertCount")]
        public int? InsertCount { get; set; }

        /// <summary>
        /// An array of the IDs of inserted entities.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("insertIds")]
        public global::System.Collections.Generic.IList<string>? InsertIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInsertResp" /> class.
        /// </summary>
        /// <param name="insertCount">
        /// The number of inserted entities.
        /// </param>
        /// <param name="insertIds">
        /// An array of the IDs of inserted entities.
        /// </param>
        public CustomerInsertResp(
            int? insertCount,
            global::System.Collections.Generic.IList<string>? insertIds)
        {
            this.InsertCount = insertCount;
            this.InsertIds = insertIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInsertResp" /> class.
        /// </summary>
        public CustomerInsertResp()
        {
        }
    }
}