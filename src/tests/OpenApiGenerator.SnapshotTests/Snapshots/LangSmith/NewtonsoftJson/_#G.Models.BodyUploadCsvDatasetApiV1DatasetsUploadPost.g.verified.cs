//HintName: G.Models.BodyUploadCsvDatasetApiV1DatasetsUploadPost.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUploadCsvDatasetApiV1DatasetsUploadPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] File { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_keys", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> InputKeys { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public global::System.AnyOf<string?, object?>? Name { get; set; }

        /// <summary>
        /// Default Value: kv
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_type")]
        public global::System.AllOf<global::G.DataType?>? DataType { get; set; } = "kv";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_keys")]
        public global::System.Collections.Generic.IList<string?>? OutputKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public global::System.AnyOf<string?, object?>? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}