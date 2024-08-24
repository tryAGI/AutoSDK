//HintName: G.Models.UploadCanvasInitImageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadCanvasInitImageRequest
    {
        /// <summary>
        /// Has to be png, jpg, jpeg, or webp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initExtension")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InitExtension { get; set; }

        /// <summary>
        /// Has to be png, jpg, jpeg, or webp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskExtension")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MaskExtension { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}