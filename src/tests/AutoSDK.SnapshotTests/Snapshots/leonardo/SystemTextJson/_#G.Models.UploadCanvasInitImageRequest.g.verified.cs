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

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadCanvasInitImageRequest" /> class.
        /// </summary>
        /// <param name="initExtension">
        /// Has to be png, jpg, jpeg, or webp.
        /// </param>
        /// <param name="maskExtension">
        /// Has to be png, jpg, jpeg, or webp.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UploadCanvasInitImageRequest(
            string initExtension,
            string maskExtension)
        {
            this.InitExtension = initExtension ?? throw new global::System.ArgumentNullException(nameof(initExtension));
            this.MaskExtension = maskExtension ?? throw new global::System.ArgumentNullException(nameof(maskExtension));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadCanvasInitImageRequest" /> class.
        /// </summary>
        public UploadCanvasInitImageRequest()
        {
        }
    }
}