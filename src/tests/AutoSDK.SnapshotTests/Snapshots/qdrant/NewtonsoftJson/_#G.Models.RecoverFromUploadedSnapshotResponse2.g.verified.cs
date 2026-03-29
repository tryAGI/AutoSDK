//HintName: G.Models.RecoverFromUploadedSnapshotResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecoverFromUploadedSnapshotResponse2
    {
        /// <summary>
        /// Time spent to process this request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time")]
        public float? Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecoverFromUploadedSnapshotResponse2" /> class.
        /// </summary>
        /// <param name="time">
        /// Time spent to process this request
        /// </param>
        /// <param name="status"></param>
        public RecoverFromUploadedSnapshotResponse2(
            float? time,
            string? status)
        {
            this.Time = time;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecoverFromUploadedSnapshotResponse2" /> class.
        /// </summary>
        public RecoverFromUploadedSnapshotResponse2()
        {
        }
    }
}