﻿//HintName: G.Models.BodyEditVoiceV1VoicesVoiceIdEditPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyEditVoiceV1VoicesVoiceIdEditPost
    {
        /// <summary>
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Audio files to add to the voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<byte[]>? Files { get; set; }

        /// <summary>
        /// How would you describe the voice?
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Serialized labels dictionary for the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public string? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyEditVoiceV1VoicesVoiceIdEditPost" /> class.
        /// </summary>
        /// <param name="name">
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </param>
        /// <param name="files">
        /// Audio files to add to the voice
        /// </param>
        /// <param name="description">
        /// How would you describe the voice?
        /// </param>
        /// <param name="labels">
        /// Serialized labels dictionary for the voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyEditVoiceV1VoicesVoiceIdEditPost(
            string name,
            global::System.Collections.Generic.IList<byte[]>? files,
            string? description,
            string? labels)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Files = files;
            this.Description = description;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyEditVoiceV1VoicesVoiceIdEditPost" /> class.
        /// </summary>
        public BodyEditVoiceV1VoicesVoiceIdEditPost()
        {
        }
    }
}