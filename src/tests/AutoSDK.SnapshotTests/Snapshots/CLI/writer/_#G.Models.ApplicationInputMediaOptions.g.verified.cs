//HintName: G.Models.ApplicationInputMediaOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options specific to media upload input fields.
    /// </summary>
    public sealed partial class ApplicationInputMediaOptions
    {
        /// <summary>
        /// List of allowed media file types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FileTypes { get; set; }

        /// <summary>
        /// Maximum media file size allowed in megabytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_image_size_mb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxImageSizeMb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInputMediaOptions" /> class.
        /// </summary>
        /// <param name="fileTypes">
        /// List of allowed media file types.
        /// </param>
        /// <param name="maxImageSizeMb">
        /// Maximum media file size allowed in megabytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplicationInputMediaOptions(
            global::System.Collections.Generic.IList<string> fileTypes,
            int maxImageSizeMb)
        {
            this.FileTypes = fileTypes ?? throw new global::System.ArgumentNullException(nameof(fileTypes));
            this.MaxImageSizeMb = maxImageSizeMb;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInputMediaOptions" /> class.
        /// </summary>
        public ApplicationInputMediaOptions()
        {
        }
    }
}