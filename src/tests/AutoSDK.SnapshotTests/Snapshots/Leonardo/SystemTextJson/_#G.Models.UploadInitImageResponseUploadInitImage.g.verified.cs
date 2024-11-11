//HintName: G.Models.UploadInitImageResponseUploadInitImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadInitImageResponseUploadInitImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public string? Fields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadInitImageResponseUploadInitImage" /> class.
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="id"></param>
        /// <param name="key"></param>
        /// <param name="url"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UploadInitImageResponseUploadInitImage(
            string? fields,
            string? id,
            string? key,
            string? url)
        {
            this.Fields = fields;
            this.Id = id;
            this.Key = key;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadInitImageResponseUploadInitImage" /> class.
        /// </summary>
        public UploadInitImageResponseUploadInitImage()
        {
        }
    }
}