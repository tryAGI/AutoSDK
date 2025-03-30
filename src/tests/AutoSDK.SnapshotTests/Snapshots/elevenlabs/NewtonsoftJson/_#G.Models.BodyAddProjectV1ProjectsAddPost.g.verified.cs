//HintName: G.Models.BodyAddProjectV1ProjectsAddPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAddProjectV1ProjectsAddPost
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
        /// The ID of the model to be used for this Studio project, you can query GET /v1/models to list all available models.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </summary>
        /// <example>21m00Tcm4TlvDq8ikWAM</example>
        [global::Newtonsoft.Json.JsonProperty("default_model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DefaultModelId { get; set; } = default!;

        /// <summary>
        /// An optional URL from which we will extract content to initialize the Studio project. If this is set, 'from_url' must be null. If neither 'from_url' or 'from_document' are provided we will initialize the Studio project as blank.<br/>
        /// Example: https://blog.elevenlabs.io/the_first_ai_that_can_laugh/
        /// </summary>
        /// <example>https://blog.elevenlabs.io/the_first_ai_that_can_laugh/</example>
        [global::Newtonsoft.Json.JsonProperty("from_url")]
        public string? FromUrl { get; set; }

        /// <summary>
        /// An optional .epub, .pdf, .txt or similar file can be provided. If provided, we will initialize the Studio project with its content. If this is set, 'from_url' must be null.  If neither 'from_url' or 'from_document' are provided we will initialize the Studio project as blank.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_document")]
        public byte[]? FromDocument { get; set; }

        /// <summary>
        /// An optional .epub, .pdf, .txt or similar file can be provided. If provided, we will initialize the Studio project with its content. If this is set, 'from_url' must be null.  If neither 'from_url' or 'from_document' are provided we will initialize the Studio project as blank.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_documentname")]
        public string? FromDocumentname { get; set; }

        /// <summary>
        /// Output quality of the generated audio. Must be one of:<br/>
        /// standard - standard output format, 128kbps with 44.1kHz sample rate.<br/>
        /// high - high quality output format, 192kbps with 44.1kHz sample rate and major improvements on our side. Using this setting increases the credit cost by 20%.<br/>
        /// ultra - ultra quality output format, 192kbps with 44.1kHz sample rate and highest improvements on our side. Using this setting increases the credit cost by 50%.<br/>
        /// ultra lossless - ultra quality output format, 705.6kbps with 44.1kHz sample rate and highest improvements on our side in a fully lossless format. Using this setting increases the credit cost by 100%.<br/>
        /// Default Value: standard<br/>
        /// Example: standard
        /// </summary>
        /// <example>standard</example>
        [global::Newtonsoft.Json.JsonProperty("quality_preset")]
        public string? QualityPreset { get; set; }

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
        /// An optional description of the Studio project.<br/>
        /// Example: A tragic love story between two young lovers.
        /// </summary>
        /// <example>A tragic love story between two young lovers.</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// An optional list of genres associated with the Studio project.<br/>
        /// Example: [Romance, Drama]
        /// </summary>
        /// <example>[Romance, Drama]</example>
        [global::Newtonsoft.Json.JsonProperty("genres")]
        public global::System.Collections.Generic.IList<string>? Genres { get; set; }

        /// <summary>
        /// An optional target audience of the Studio project.<br/>
        /// Example: adult
        /// </summary>
        /// <example>adult</example>
        [global::Newtonsoft.Json.JsonProperty("target_audience")]
        public global::G.BodyAddProjectV1ProjectsAddPostTargetAudience? TargetAudience { get; set; }

        /// <summary>
        /// An optional language of the Studio project. Two-letter language code (ISO 639-1).<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// An optional content type of the Studio project.<br/>
        /// Example: Book
        /// </summary>
        /// <example>Book</example>
        [global::Newtonsoft.Json.JsonProperty("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// An optional original publication date of the Studio project, in the format YYYY-MM-DD or YYYY.<br/>
        /// Example: 1597-01-01
        /// </summary>
        /// <example>1597-01-01</example>
        [global::Newtonsoft.Json.JsonProperty("original_publication_date")]
        public string? OriginalPublicationDate { get; set; }

        /// <summary>
        /// An optional specification of whether this Studio project contains mature content.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("mature_content")]
        public bool? MatureContent { get; set; }

        /// <summary>
        /// An optional ISBN number of the Studio project you want to create, this will be added as metadata to the mp3 file on Studio project or chapter download.<br/>
        /// Example: 0-306-40615-2
        /// </summary>
        /// <example>0-306-40615-2</example>
        [global::Newtonsoft.Json.JsonProperty("isbn_number")]
        public string? IsbnNumber { get; set; }

        /// <summary>
        /// [Deprecated] When the Studio project is downloaded, should the returned audio have postprocessing in order to make it compliant with audiobook normalized volume requirements<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("acx_volume_normalization")]
        public bool? AcxVolumeNormalization { get; set; }

        /// <summary>
        /// When the Studio project is downloaded, should the returned audio have postprocessing in order to make it compliant with audiobook normalized volume requirements<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("volume_normalization")]
        public bool? VolumeNormalization { get; set; }

        /// <summary>
        /// A list of pronunciation dictionary locators (pronunciation_dictionary_id, version_id) encoded as a list of JSON strings for pronunciation dictionaries to be applied to the text. A list of json encoded strings is required as adding projects may occur through formData as opposed to jsonBody. To specify multiple dictionaries use multiple --form lines in your curl, such as --form 'pronunciation_dictionary_locators="{\"pronunciation_dictionary_id\":\"Vmd4Zor6fplcA7WrINey\",\"version_id\":\"hRPaxjlTdR7wFMhV4w0b\"}"' --form 'pronunciation_dictionary_locators="{\"pronunciation_dictionary_id\":\"JzWtcGQMJ6bnlWwyMo7e\",\"version_id\":\"lbmwxiLu4q6txYxgdZqn\"}"'. Note that multiple dictionaries are not currently supported by our UI which will only show the first.<br/>
        /// Example: [{"pronunciation_dictionary_id": "test", "version_id": "id2"}]
        /// </summary>
        /// <example>[{"pronunciation_dictionary_id": "test", "version_id": "id2"}]</example>
        [global::Newtonsoft.Json.JsonProperty("pronunciation_dictionary_locators")]
        public global::System.Collections.Generic.IList<string>? PronunciationDictionaryLocators { get; set; }

        /// <summary>
        /// A url that will be called by our service when the Studio project is converted. Request will contain a json blob containing the status of the conversion<br/>
        /// Example: [https://www.test.com/my-api/projects-status]
        /// </summary>
        /// <example>[https://www.test.com/my-api/projects-status]</example>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// An optional specification of whether the content of this Studio project is fiction.<br/>
        /// Example: fiction
        /// </summary>
        /// <example>fiction</example>
        [global::Newtonsoft.Json.JsonProperty("fiction")]
        public global::G.BodyAddProjectV1ProjectsAddPostFiction? Fiction { get; set; }

        /// <summary>
        ///     This parameter controls text normalization with four modes: 'auto', 'on', 'apply_english' and 'off'.<br/>
        ///     When set to 'auto', the system will automatically decide whether to apply text normalization<br/>
        ///     (e.g., spelling out numbers). With 'on', text normalization will always be applied, while<br/>
        ///     with 'off', it will be skipped. 'apply_english' is the same as 'on' but will assume that text is in English.<br/>
        ///     
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apply_text_normalization")]
        public global::G.BodyAddProjectV1ProjectsAddPostApplyTextNormalization? ApplyTextNormalization { get; set; }

        /// <summary>
        /// Whether to auto convert the Studio project to audio or not.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_convert")]
        public bool? AutoConvert { get; set; }

        /// <summary>
        /// [Alpha Feature] Whether automatically assign voices to phrases in the create Project.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_assign_voices")]
        public bool? AutoAssignVoices { get; set; }

        /// <summary>
        /// The type of Studio project to create.<br/>
        /// Example: book
        /// </summary>
        /// <example>book</example>
        [global::Newtonsoft.Json.JsonProperty("source_type")]
        public global::G.BodyAddProjectV1ProjectsAddPostSourceType? SourceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddProjectV1ProjectsAddPost" /> class.
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
        /// <param name="defaultModelId">
        /// The ID of the model to be used for this Studio project, you can query GET /v1/models to list all available models.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="fromUrl">
        /// An optional URL from which we will extract content to initialize the Studio project. If this is set, 'from_url' must be null. If neither 'from_url' or 'from_document' are provided we will initialize the Studio project as blank.<br/>
        /// Example: https://blog.elevenlabs.io/the_first_ai_that_can_laugh/
        /// </param>
        /// <param name="fromDocument">
        /// An optional .epub, .pdf, .txt or similar file can be provided. If provided, we will initialize the Studio project with its content. If this is set, 'from_url' must be null.  If neither 'from_url' or 'from_document' are provided we will initialize the Studio project as blank.
        /// </param>
        /// <param name="fromDocumentname">
        /// An optional .epub, .pdf, .txt or similar file can be provided. If provided, we will initialize the Studio project with its content. If this is set, 'from_url' must be null.  If neither 'from_url' or 'from_document' are provided we will initialize the Studio project as blank.
        /// </param>
        /// <param name="qualityPreset">
        /// Output quality of the generated audio. Must be one of:<br/>
        /// standard - standard output format, 128kbps with 44.1kHz sample rate.<br/>
        /// high - high quality output format, 192kbps with 44.1kHz sample rate and major improvements on our side. Using this setting increases the credit cost by 20%.<br/>
        /// ultra - ultra quality output format, 192kbps with 44.1kHz sample rate and highest improvements on our side. Using this setting increases the credit cost by 50%.<br/>
        /// ultra lossless - ultra quality output format, 705.6kbps with 44.1kHz sample rate and highest improvements on our side in a fully lossless format. Using this setting increases the credit cost by 100%.<br/>
        /// Default Value: standard<br/>
        /// Example: standard
        /// </param>
        /// <param name="title">
        /// An optional name of the author of the Studio project, this will be added as metadata to the mp3 file on Studio project or chapter download.<br/>
        /// Example: Romeo and Juliet
        /// </param>
        /// <param name="author">
        /// An optional name of the author of the Studio project, this will be added as metadata to the mp3 file on Studio project or chapter download.<br/>
        /// Example: William Shakespeare
        /// </param>
        /// <param name="description">
        /// An optional description of the Studio project.<br/>
        /// Example: A tragic love story between two young lovers.
        /// </param>
        /// <param name="genres">
        /// An optional list of genres associated with the Studio project.<br/>
        /// Example: [Romance, Drama]
        /// </param>
        /// <param name="targetAudience">
        /// An optional target audience of the Studio project.<br/>
        /// Example: adult
        /// </param>
        /// <param name="language">
        /// An optional language of the Studio project. Two-letter language code (ISO 639-1).<br/>
        /// Example: en
        /// </param>
        /// <param name="contentType">
        /// An optional content type of the Studio project.<br/>
        /// Example: Book
        /// </param>
        /// <param name="originalPublicationDate">
        /// An optional original publication date of the Studio project, in the format YYYY-MM-DD or YYYY.<br/>
        /// Example: 1597-01-01
        /// </param>
        /// <param name="matureContent">
        /// An optional specification of whether this Studio project contains mature content.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="isbnNumber">
        /// An optional ISBN number of the Studio project you want to create, this will be added as metadata to the mp3 file on Studio project or chapter download.<br/>
        /// Example: 0-306-40615-2
        /// </param>
        /// <param name="acxVolumeNormalization">
        /// [Deprecated] When the Studio project is downloaded, should the returned audio have postprocessing in order to make it compliant with audiobook normalized volume requirements<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="volumeNormalization">
        /// When the Studio project is downloaded, should the returned audio have postprocessing in order to make it compliant with audiobook normalized volume requirements<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="pronunciationDictionaryLocators">
        /// A list of pronunciation dictionary locators (pronunciation_dictionary_id, version_id) encoded as a list of JSON strings for pronunciation dictionaries to be applied to the text. A list of json encoded strings is required as adding projects may occur through formData as opposed to jsonBody. To specify multiple dictionaries use multiple --form lines in your curl, such as --form 'pronunciation_dictionary_locators="{\"pronunciation_dictionary_id\":\"Vmd4Zor6fplcA7WrINey\",\"version_id\":\"hRPaxjlTdR7wFMhV4w0b\"}"' --form 'pronunciation_dictionary_locators="{\"pronunciation_dictionary_id\":\"JzWtcGQMJ6bnlWwyMo7e\",\"version_id\":\"lbmwxiLu4q6txYxgdZqn\"}"'. Note that multiple dictionaries are not currently supported by our UI which will only show the first.<br/>
        /// Example: [{"pronunciation_dictionary_id": "test", "version_id": "id2"}]
        /// </param>
        /// <param name="callbackUrl">
        /// A url that will be called by our service when the Studio project is converted. Request will contain a json blob containing the status of the conversion<br/>
        /// Example: [https://www.test.com/my-api/projects-status]
        /// </param>
        /// <param name="fiction">
        /// An optional specification of whether the content of this Studio project is fiction.<br/>
        /// Example: fiction
        /// </param>
        /// <param name="applyTextNormalization">
        ///     This parameter controls text normalization with four modes: 'auto', 'on', 'apply_english' and 'off'.<br/>
        ///     When set to 'auto', the system will automatically decide whether to apply text normalization<br/>
        ///     (e.g., spelling out numbers). With 'on', text normalization will always be applied, while<br/>
        ///     with 'off', it will be skipped. 'apply_english' is the same as 'on' but will assume that text is in English.<br/>
        ///     
        /// </param>
        /// <param name="autoConvert">
        /// Whether to auto convert the Studio project to audio or not.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="autoAssignVoices">
        /// [Alpha Feature] Whether automatically assign voices to phrases in the create Project.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sourceType">
        /// The type of Studio project to create.<br/>
        /// Example: book
        /// </param>
        public BodyAddProjectV1ProjectsAddPost(
            string name,
            string defaultTitleVoiceId,
            string defaultParagraphVoiceId,
            string defaultModelId,
            string? fromUrl,
            byte[]? fromDocument,
            string? fromDocumentname,
            string? qualityPreset,
            string? title,
            string? author,
            string? description,
            global::System.Collections.Generic.IList<string>? genres,
            global::G.BodyAddProjectV1ProjectsAddPostTargetAudience? targetAudience,
            string? language,
            string? contentType,
            string? originalPublicationDate,
            bool? matureContent,
            string? isbnNumber,
            bool? acxVolumeNormalization,
            bool? volumeNormalization,
            global::System.Collections.Generic.IList<string>? pronunciationDictionaryLocators,
            string? callbackUrl,
            global::G.BodyAddProjectV1ProjectsAddPostFiction? fiction,
            global::G.BodyAddProjectV1ProjectsAddPostApplyTextNormalization? applyTextNormalization,
            bool? autoConvert,
            bool? autoAssignVoices,
            global::G.BodyAddProjectV1ProjectsAddPostSourceType? sourceType)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DefaultTitleVoiceId = defaultTitleVoiceId ?? throw new global::System.ArgumentNullException(nameof(defaultTitleVoiceId));
            this.DefaultParagraphVoiceId = defaultParagraphVoiceId ?? throw new global::System.ArgumentNullException(nameof(defaultParagraphVoiceId));
            this.DefaultModelId = defaultModelId ?? throw new global::System.ArgumentNullException(nameof(defaultModelId));
            this.FromUrl = fromUrl;
            this.FromDocument = fromDocument;
            this.FromDocumentname = fromDocumentname;
            this.QualityPreset = qualityPreset;
            this.Title = title;
            this.Author = author;
            this.Description = description;
            this.Genres = genres;
            this.TargetAudience = targetAudience;
            this.Language = language;
            this.ContentType = contentType;
            this.OriginalPublicationDate = originalPublicationDate;
            this.MatureContent = matureContent;
            this.IsbnNumber = isbnNumber;
            this.AcxVolumeNormalization = acxVolumeNormalization;
            this.VolumeNormalization = volumeNormalization;
            this.PronunciationDictionaryLocators = pronunciationDictionaryLocators;
            this.CallbackUrl = callbackUrl;
            this.Fiction = fiction;
            this.ApplyTextNormalization = applyTextNormalization;
            this.AutoConvert = autoConvert;
            this.AutoAssignVoices = autoAssignVoices;
            this.SourceType = sourceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddProjectV1ProjectsAddPost" /> class.
        /// </summary>
        public BodyAddProjectV1ProjectsAddPost()
        {
        }
    }
}