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
        [global::Newtonsoft.Json.JsonProperty("file_types", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> FileTypes { get; set; } = default!;

        /// <summary>
        /// Maximum media file size allowed in megabytes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_image_size_mb", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxImageSizeMb { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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