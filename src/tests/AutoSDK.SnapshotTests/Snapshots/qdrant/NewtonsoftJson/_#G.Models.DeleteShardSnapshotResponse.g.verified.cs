//HintName: G.Models.DeleteShardSnapshotResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteShardSnapshotResponse
    {
        /// <summary>
        /// Time spent to process this request<br/>
        /// Example: 0.002F
        /// </summary>
        /// <example>0.002F</example>
        [global::Newtonsoft.Json.JsonProperty("time")]
        public float? Time { get; set; }

        /// <summary>
        /// Example: ok
        /// </summary>
        /// <example>ok</example>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public bool? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteShardSnapshotResponse" /> class.
        /// </summary>
        /// <param name="time">
        /// Time spent to process this request<br/>
        /// Example: 0.002F
        /// </param>
        /// <param name="status">
        /// Example: ok
        /// </param>
        /// <param name="result"></param>
        public DeleteShardSnapshotResponse(
            float? time,
            string? status,
            bool? result)
        {
            this.Time = time;
            this.Status = status;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteShardSnapshotResponse" /> class.
        /// </summary>
        public DeleteShardSnapshotResponse()
        {
        }
    }
}