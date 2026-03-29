//HintName: G.Models.VimeoDestinationOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pass additional options to control how Vimeo publishes video, including name, description and privacy settings.
    /// </summary>
    public sealed partial class VimeoDestinationOptions
    {
        /// <summary>
        /// A name or title for the video that will be displayed on the Vimeo website.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of the video that will be displayed on the Vimeo website.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Options to control the visibility of videos and privacy features.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privacy")]
        public global::G.VimeoDestinationPrivacyOptions? Privacy { get; set; }

        /// <summary>
        /// The Vimeo folder URI to upload the video to. The folder must already exist in your Vimeo account.<br/>
        /// Example: /users/12345678/projects/87654321
        /// </summary>
        /// <example>/users/12345678/projects/87654321</example>
        [global::Newtonsoft.Json.JsonProperty("folderUri")]
        public string? FolderUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VimeoDestinationOptions" /> class.
        /// </summary>
        /// <param name="name">
        /// A name or title for the video that will be displayed on the Vimeo website.
        /// </param>
        /// <param name="description">
        /// A description of the video that will be displayed on the Vimeo website.
        /// </param>
        /// <param name="privacy">
        /// Options to control the visibility of videos and privacy features.
        /// </param>
        /// <param name="folderUri">
        /// The Vimeo folder URI to upload the video to. The folder must already exist in your Vimeo account.<br/>
        /// Example: /users/12345678/projects/87654321
        /// </param>
        public VimeoDestinationOptions(
            string? name,
            string? description,
            global::G.VimeoDestinationPrivacyOptions? privacy,
            string? folderUri)
        {
            this.Name = name;
            this.Description = description;
            this.Privacy = privacy;
            this.FolderUri = folderUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VimeoDestinationOptions" /> class.
        /// </summary>
        public VimeoDestinationOptions()
        {
        }
    }
}