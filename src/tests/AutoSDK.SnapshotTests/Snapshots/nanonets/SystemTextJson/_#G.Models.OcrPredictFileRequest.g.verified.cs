//HintName: G.Models.OcrPredictFileRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcrPredictFileRequest
    {
        /// <summary>
        /// The file to be uploaded.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: PNG, JPEG or PDF
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The file to be uploaded.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: PNG, JPEG or PDF
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrPredictFileRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// The file to be uploaded.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: PNG, JPEG or PDF
        /// </param>
        /// <param name="filename">
        /// The file to be uploaded.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: PNG, JPEG or PDF
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcrPredictFileRequest(
            byte[] file,
            string filename)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrPredictFileRequest" /> class.
        /// </summary>
        public OcrPredictFileRequest()
        {
        }
    }
}