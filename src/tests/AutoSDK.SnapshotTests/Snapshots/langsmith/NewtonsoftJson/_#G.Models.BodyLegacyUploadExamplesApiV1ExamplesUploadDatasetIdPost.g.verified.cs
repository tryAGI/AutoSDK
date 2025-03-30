//HintName: G.Models.BodyLegacyUploadExamplesApiV1ExamplesUploadDatasetIdPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyLegacyUploadExamplesApiV1ExamplesUploadDatasetIdPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] File { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_keys", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> InputKeys { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_keys")]
        public global::System.Collections.Generic.IList<string>? OutputKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyLegacyUploadExamplesApiV1ExamplesUploadDatasetIdPost" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="inputKeys"></param>
        /// <param name="outputKeys"></param>
        public BodyLegacyUploadExamplesApiV1ExamplesUploadDatasetIdPost(
            byte[] file,
            string filename,
            global::System.Collections.Generic.IList<string> inputKeys,
            global::System.Collections.Generic.IList<string>? outputKeys)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.InputKeys = inputKeys ?? throw new global::System.ArgumentNullException(nameof(inputKeys));
            this.OutputKeys = outputKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyLegacyUploadExamplesApiV1ExamplesUploadDatasetIdPost" /> class.
        /// </summary>
        public BodyLegacyUploadExamplesApiV1ExamplesUploadDatasetIdPost()
        {
        }
    }
}