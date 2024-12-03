//HintName: G.Models.BodyUploadExamplesApiV1ExamplesUploadDatasetIdPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUploadExamplesApiV1ExamplesUploadDatasetIdPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> InputKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_keys")]
        public global::System.Collections.Generic.IList<string>? OutputKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadExamplesApiV1ExamplesUploadDatasetIdPost" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="inputKeys"></param>
        /// <param name="outputKeys"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BodyUploadExamplesApiV1ExamplesUploadDatasetIdPost(
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
        /// Initializes a new instance of the <see cref="BodyUploadExamplesApiV1ExamplesUploadDatasetIdPost" /> class.
        /// </summary>
        public BodyUploadExamplesApiV1ExamplesUploadDatasetIdPost()
        {
        }
    }
}