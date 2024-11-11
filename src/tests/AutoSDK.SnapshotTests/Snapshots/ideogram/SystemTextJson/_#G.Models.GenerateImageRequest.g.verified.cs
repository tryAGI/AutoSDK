//HintName: G.Models.GenerateImageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateImageRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ImageRequest ImageRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequest" /> class.
        /// </summary>
        /// <param name="imageRequest"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GenerateImageRequest(
            global::G.ImageRequest imageRequest)
        {
            this.ImageRequest = imageRequest ?? throw new global::System.ArgumentNullException(nameof(imageRequest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequest" /> class.
        /// </summary>
        public GenerateImageRequest()
        {
        }
    }
}