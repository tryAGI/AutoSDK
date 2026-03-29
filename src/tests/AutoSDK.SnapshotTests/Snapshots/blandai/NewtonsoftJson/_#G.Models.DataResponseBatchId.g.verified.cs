//HintName: G.Models.DataResponseBatchId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataResponseBatchId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.DataResponseBatchIdData? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors")]
        public object? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataResponseBatchId" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="errors"></param>
        public DataResponseBatchId(
            global::G.DataResponseBatchIdData? data,
            object? errors)
        {
            this.Data = data;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataResponseBatchId" /> class.
        /// </summary>
        public DataResponseBatchId()
        {
        }
    }
}