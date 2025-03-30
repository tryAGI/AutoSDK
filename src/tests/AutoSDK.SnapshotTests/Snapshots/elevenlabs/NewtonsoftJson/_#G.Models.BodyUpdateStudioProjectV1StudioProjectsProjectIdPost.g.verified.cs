//HintName: G.Models.BodyUpdateStudioProjectV1StudioProjectsProjectIdPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateStudioProjectV1StudioProjectsProjectIdPost
    {
        /// <summary>
        /// The name of the Studio project, used for identification only.<br/>
        /// Example: Project 1
        /// </summary>
        /// <example>Project 1</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The voice_id that corresponds to the default voice used for new titles.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </summary>
        /// <example>21m00Tcm4TlvDq8ikWAM</example>
        [global::Newtonsoft.Json.JsonProperty("default_title_voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DefaultTitleVoiceId { get; set; } = default!;

        /// <summary>
        /// The voice_id that corresponds to the default voice used for new paragraphs.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </summary>
        /// <example>21m00Tcm4TlvDq8ikWAM</example>
        [global::Newtonsoft.Json.JsonProperty("default_paragraph_voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DefaultParagraphVoiceId { get; set; } = default!;

        /// <summary>
        /// An optional name of the author of the Studio project, this will be added as metadata to the mp3 file on Studio project or chapter download.<br/>
        /// Example: Romeo and Juliet
        /// </summary>
        /// <example>Romeo and Juliet</example>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// An optional name of the author of the Studio project, this will be added as metadata to the mp3 file on Studio project or chapter download.<br/>
        /// Example: William Shakespeare
        /// </summary>
        /// <example>William Shakespeare</example>
        [global::Newtonsoft.Json.JsonProperty("author")]
        public string? Author { get; set; }

        /// <summary>
        /// An optional ISBN number of the Studio project you want to create, this will be added as metadata to the mp3 file on Studio project or chapter download.<br/>
        /// Example: 0-306-40615-2
        /// </summary>
        /// <example>0-306-40615-2</example>
        [global::Newtonsoft.Json.JsonProperty("isbn_number")]
        public string? IsbnNumber { get; set; }

        /// <summary>
        /// When the Studio project is downloaded, should the returned audio have postprocessing in order to make it compliant with audiobook normalized volume requirements<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("volume_normalization")]
        public bool? VolumeNormalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateStudioProjectV1StudioProjectsProjectIdPost" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the Studio project, used for identification only.<br/>
        /// Example: Project 1
        /// </param>
        /// <param name="defaultTitleVoiceId">
        /// The voice_id that corresponds to the default voice used for new titles.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="defaultParagraphVoiceId">
        /// The voice_id that corresponds to the default voice used for new paragraphs.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="title">
        /// An optional name of the author of the Studio project, this will be added as metadata to the mp3 file on Studio project or chapter download.<br/>
        /// Example: Romeo and Juliet
        /// </param>
        /// <param name="author">
        /// An optional name of the author of the Studio project, this will be added as metadata to the mp3 file on Studio project or chapter download.<br/>
        /// Example: William Shakespeare
        /// </param>
        /// <param name="isbnNumber">
        /// An optional ISBN number of the Studio project you want to create, this will be added as metadata to the mp3 file on Studio project or chapter download.<br/>
        /// Example: 0-306-40615-2
        /// </param>
        /// <param name="volumeNormalization">
        /// When the Studio project is downloaded, should the returned audio have postprocessing in order to make it compliant with audiobook normalized volume requirements<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        public BodyUpdateStudioProjectV1StudioProjectsProjectIdPost(
            string name,
            string defaultTitleVoiceId,
            string defaultParagraphVoiceId,
            string? title,
            string? author,
            string? isbnNumber,
            bool? volumeNormalization)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DefaultTitleVoiceId = defaultTitleVoiceId ?? throw new global::System.ArgumentNullException(nameof(defaultTitleVoiceId));
            this.DefaultParagraphVoiceId = defaultParagraphVoiceId ?? throw new global::System.ArgumentNullException(nameof(defaultParagraphVoiceId));
            this.Title = title;
            this.Author = author;
            this.IsbnNumber = isbnNumber;
            this.VolumeNormalization = volumeNormalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateStudioProjectV1StudioProjectsProjectIdPost" /> class.
        /// </summary>
        public BodyUpdateStudioProjectV1StudioProjectsProjectIdPost()
        {
        }
    }
}