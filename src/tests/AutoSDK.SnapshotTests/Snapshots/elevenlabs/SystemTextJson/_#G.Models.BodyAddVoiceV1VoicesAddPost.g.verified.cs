//HintName: G.Models.BodyAddVoiceV1VoicesAddPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAddVoiceV1VoicesAddPost
    {
        /// <summary>
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A list of file paths to audio recordings intended for voice cloning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Files { get; set; }

        /// <summary>
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_background_noise")]
        public bool? RemoveBackgroundNoise { get; set; }

        /// <summary>
        /// A description of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Labels for the voice. Keys can be language, accent, gender, or age.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>))]
        public global::G.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, string, object>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddVoiceV1VoicesAddPost" /> class.
        /// </summary>
        /// <param name="name">
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </param>
        /// <param name="files">
        /// A list of file paths to audio recordings intended for voice cloning.
        /// </param>
        /// <param name="removeBackgroundNoise">
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="description">
        /// A description of the voice.
        /// </param>
        /// <param name="labels">
        /// Labels for the voice. Keys can be language, accent, gender, or age.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyAddVoiceV1VoicesAddPost(
            string name,
            global::System.Collections.Generic.IList<byte[]> files,
            bool? removeBackgroundNoise,
            string? description,
            global::G.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, string, object>? labels)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.RemoveBackgroundNoise = removeBackgroundNoise;
            this.Description = description;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddVoiceV1VoicesAddPost" /> class.
        /// </summary>
        public BodyAddVoiceV1VoicesAddPost()
        {
        }
    }
}