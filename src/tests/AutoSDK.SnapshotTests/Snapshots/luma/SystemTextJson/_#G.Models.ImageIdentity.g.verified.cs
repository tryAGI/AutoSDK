//HintName: G.Models.ImageIdentity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The image identity object
    /// </summary>
    public sealed partial class ImageIdentity
    {
        /// <summary>
        /// The URLs of the image identity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<string>? Images { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageIdentity" /> class.
        /// </summary>
        /// <param name="images">
        /// The URLs of the image identity
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ImageIdentity(
            global::System.Collections.Generic.IList<string>? images)
        {
            this.Images = images;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageIdentity" /> class.
        /// </summary>
        public ImageIdentity()
        {
        }
    }
}