//HintName: G.Models.CreateDatasetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetRequest
    {
        /// <summary>
        /// The file to upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Data { get; set; }

        /// <summary>
        /// The file to upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dataname { get; set; }

        /// <summary>
        /// An optional evaluation file to upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_data")]
        public byte[]? EvalData { get; set; }

        /// <summary>
        /// An optional evaluation file to upload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_dataname")]
        public string? EvalDataname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetRequest" /> class.
        /// </summary>
        /// <param name="data">
        /// The file to upload
        /// </param>
        /// <param name="dataname">
        /// The file to upload
        /// </param>
        /// <param name="evalData">
        /// An optional evaluation file to upload
        /// </param>
        /// <param name="evalDataname">
        /// An optional evaluation file to upload
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateDatasetRequest(
            byte[] data,
            string dataname,
            byte[]? evalData,
            string? evalDataname)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Dataname = dataname ?? throw new global::System.ArgumentNullException(nameof(dataname));
            this.EvalData = evalData;
            this.EvalDataname = evalDataname;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetRequest" /> class.
        /// </summary>
        public CreateDatasetRequest()
        {
        }
    }
}