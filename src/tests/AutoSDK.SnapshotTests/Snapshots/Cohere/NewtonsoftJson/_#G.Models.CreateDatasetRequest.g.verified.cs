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
    }
}