//HintName: G.Models.FitToImagesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FitToImagesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageMode")]
        public string? ImageMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FitToImagesRequest" /> class.
        /// </summary>
        /// <param name="imageMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FitToImagesRequest(
            string? imageMode)
        {
            this.ImageMode = imageMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FitToImagesRequest" /> class.
        /// </summary>
        public FitToImagesRequest()
        {
        }
    }
}