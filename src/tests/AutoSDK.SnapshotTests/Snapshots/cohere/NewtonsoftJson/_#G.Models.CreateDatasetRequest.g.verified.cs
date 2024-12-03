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
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] Data { get; set; } = default!;

        /// <summary>
        /// The file to upload
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataname", Required = global::Newtonsoft.Json.Required.Always)]
        public string Dataname { get; set; } = default!;

        /// <summary>
        /// An optional evaluation file to upload
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eval_data")]
        public byte[]? EvalData { get; set; }

        /// <summary>
        /// An optional evaluation file to upload
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eval_dataname")]
        public string? EvalDataname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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