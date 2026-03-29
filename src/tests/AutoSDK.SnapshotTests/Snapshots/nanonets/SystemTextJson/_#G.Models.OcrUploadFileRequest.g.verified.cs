//HintName: G.Models.OcrUploadFileRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcrUploadFileRequest
    {
        /// <summary>
        /// The name of the file to be uploaded.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: `"data": "[{"filename": "filename.ext"}]"`.<br/>
        /// &lt;br /&gt;<br/>
        /// **NOTE**: The `filename` must be the same as the uploaded file name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

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
        /// Initializes a new instance of the <see cref="OcrUploadFileRequest" /> class.
        /// </summary>
        /// <param name="data">
        /// The name of the file to be uploaded.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: `"data": "[{"filename": "filename.ext"}]"`.<br/>
        /// &lt;br /&gt;<br/>
        /// **NOTE**: The `filename` must be the same as the uploaded file name.
        /// </param>
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
        public OcrUploadFileRequest(
            string data,
            byte[] file,
            string filename)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrUploadFileRequest" /> class.
        /// </summary>
        public OcrUploadFileRequest()
        {
        }
    }
}