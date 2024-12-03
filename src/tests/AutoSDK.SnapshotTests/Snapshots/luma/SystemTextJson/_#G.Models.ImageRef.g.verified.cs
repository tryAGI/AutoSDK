//HintName: G.Models.ImageRef.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The image reference object
    /// </summary>
    public sealed partial class ImageRef
    {
        /// <summary>
        /// The URL of the image reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The weight of the image reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageRef" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the image reference
        /// </param>
        /// <param name="weight">
        /// The weight of the image reference
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ImageRef(
            string? url,
            double? weight)
        {
            this.Url = url;
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageRef" /> class.
        /// </summary>
        public ImageRef()
        {
        }
    }
}