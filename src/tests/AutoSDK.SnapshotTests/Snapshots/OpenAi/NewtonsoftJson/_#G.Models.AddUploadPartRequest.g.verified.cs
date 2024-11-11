//HintName: G.Models.AddUploadPartRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddUploadPartRequest
    {
        /// <summary>
        /// The chunk of bytes for this Part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] Data { get; set; } = default!;

        /// <summary>
        /// The chunk of bytes for this Part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataname", Required = global::Newtonsoft.Json.Required.Always)]
        public string Dataname { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddUploadPartRequest" /> class.
        /// </summary>
        /// <param name="data">
        /// The chunk of bytes for this Part.
        /// </param>
        /// <param name="dataname">
        /// The chunk of bytes for this Part.
        /// </param>
        public AddUploadPartRequest(
            byte[] data,
            string dataname)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Dataname = dataname ?? throw new global::System.ArgumentNullException(nameof(dataname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddUploadPartRequest" /> class.
        /// </summary>
        public AddUploadPartRequest()
        {
        }
    }
}