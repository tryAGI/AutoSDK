//HintName: G.Models.CreateShardSnapshotResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateShardSnapshotResponse
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
        /// Example: {"name":"my-collection-3766212330831337-2024-07-22-08-31-55.snapshot","creation_time":"2022-08-04T10:49:10","size":1000000,"checksum":"a1b2c3d4e5f6a7b8c9d0e1f2a3b4c5d6e7f8a9b0c1d2e3f4a5b6c7d8e9f0"}
        /// </summary>
        /// <example>{"name":"my-collection-3766212330831337-2024-07-22-08-31-55.snapshot","creation_time":"2022-08-04T10:49:10","size":1000000,"checksum":"a1b2c3d4e5f6a7b8c9d0e1f2a3b4c5d6e7f8a9b0c1d2e3f4a5b6c7d8e9f0"}</example>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.SnapshotDescription? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShardSnapshotResponse" /> class.
        /// </summary>
        /// <param name="time">
        /// Time spent to process this request<br/>
        /// Example: 0.002F
        /// </param>
        /// <param name="status">
        /// Example: ok
        /// </param>
        /// <param name="result">
        /// Example: {"name":"my-collection-3766212330831337-2024-07-22-08-31-55.snapshot","creation_time":"2022-08-04T10:49:10","size":1000000,"checksum":"a1b2c3d4e5f6a7b8c9d0e1f2a3b4c5d6e7f8a9b0c1d2e3f4a5b6c7d8e9f0"}
        /// </param>
        public CreateShardSnapshotResponse(
            float? time,
            string? status,
            global::G.SnapshotDescription? result)
        {
            this.Time = time;
            this.Status = status;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShardSnapshotResponse" /> class.
        /// </summary>
        public CreateShardSnapshotResponse()
        {
        }
    }
}