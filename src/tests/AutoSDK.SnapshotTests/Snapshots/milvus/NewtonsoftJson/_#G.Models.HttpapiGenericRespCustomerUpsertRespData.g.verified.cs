//HintName: G.Models.HttpapiGenericRespCustomerUpsertRespData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HttpapiGenericRespCustomerUpsertRespData
    {
        /// <summary>
        /// The number of inserted entities.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upsertCount")]
        public int? UpsertCount { get; set; }

        /// <summary>
        /// An array of the IDs of inserted entities.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upsertIds")]
        public global::System.Collections.Generic.IList<string>? UpsertIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpapiGenericRespCustomerUpsertRespData" /> class.
        /// </summary>
        /// <param name="upsertCount">
        /// The number of inserted entities.
        /// </param>
        /// <param name="upsertIds">
        /// An array of the IDs of inserted entities.
        /// </param>
        public HttpapiGenericRespCustomerUpsertRespData(
            int? upsertCount,
            global::System.Collections.Generic.IList<string>? upsertIds)
        {
            this.UpsertCount = upsertCount;
            this.UpsertIds = upsertIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpapiGenericRespCustomerUpsertRespData" /> class.
        /// </summary>
        public HttpapiGenericRespCustomerUpsertRespData()
        {
        }
    }
}