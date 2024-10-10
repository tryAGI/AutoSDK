//HintName: G.IProjectsClient.AddProjectV1ProjectsAddPost.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Add Project<br/>
        /// Creates a new project, it can be either initialized as blank, from a document or from a URL.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddProjectResponseModel> AddProjectV1ProjectsAddPostAsync(
            global::G.BodyAddProjectV1ProjectsAddPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add Project<br/>
        /// Creates a new project, it can be either initialized as blank, from a document or from a URL.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="name">
        /// The name of the project, used for identification only.
        /// </param>
        /// <param name="defaultTitleVoiceId">
        /// The voice_id that corresponds to the default voice used for new titles.
        /// </param>
        /// <param name="defaultParagraphVoiceId">
        /// The voice_id that corresponds to the default voice used for new paragraphs.
        /// </param>
        /// <param name="defaultModelId">
        /// The model_id of the model to be used for this project, you can query GET https://api.elevenlabs.io/v1/models to list all available models.
        /// </param>
        /// <param name="fromUrl">
        /// An optional URL from which we will extract content to initialize the project. If this is set, 'from_url' must be null. If neither 'from_url' or 'from_document' are provided we will initialize the project as blank.
        /// </param>
        /// <param name="fromDocument">
        /// An optional .epub, .pdf, .txt or similar file can be provided. If provided, we will initialize the project with its content. If this is set, 'from_url' must be null.  If neither 'from_url' or 'from_document' are provided we will initialize the project as blank.
        /// </param>
        /// <param name="fromDocumentname">
        /// An optional .epub, .pdf, .txt or similar file can be provided. If provided, we will initialize the project with its content. If this is set, 'from_url' must be null.  If neither 'from_url' or 'from_document' are provided we will initialize the project as blank.
        /// </param>
        /// <param name="qualityPreset">
        /// Output quality of the generated audio. Must be one of:<br/>
        /// standard - standard output format, 128kbps with 44.1kHz sample rate.<br/>
        /// high - high quality output format, 192kbps with 44.1kHz sample rate and major improvements on our side. Using this setting increases the credit cost by 20%.<br/>
        /// ultra - ultra quality output format, 192kbps with 44.1kHz sample rate and highest improvements on our side. Using this setting increases the credit cost by 50%.<br/>
        /// ultra lossless - ultra quality output format, 705.6kbps with 44.1kHz sample rate and highest improvements on our side in a fully lossless format. Using this setting increases the credit cost by 100%.<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="title">
        /// An optional name of the author of the project, this will be added as metadata to the mp3 file on project / chapter download.
        /// </param>
        /// <param name="author">
        /// An optional name of the author of the project, this will be added as metadata to the mp3 file on project / chapter download.
        /// </param>
        /// <param name="description">
        /// An optional description of the project.
        /// </param>
        /// <param name="genres">
        /// An optional list of genres associated with the project.
        /// </param>
        /// <param name="targetAudience">
        /// An optional target audience of the project.
        /// </param>
        /// <param name="language">
        /// An optional language of the project. Two-letter language code (ISO 639-1).
        /// </param>
        /// <param name="contentType">
        /// An optional content type of the project.
        /// </param>
        /// <param name="originalPublicationDate">
        /// An optional original publication date of the project, in the format YYYY-MM-DD or YYYY.
        /// </param>
        /// <param name="matureContent">
        /// An optional mature content of the project.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="isbnNumber">
        /// An optional ISBN number of the project you want to create, this will be added as metadata to the mp3 file on project / chapter download.
        /// </param>
        /// <param name="acxVolumeNormalization">
        /// [Deprecated] When the project is downloaded, should the returned audio have postprocessing in order to make it compliant with audiobook normalized volume requirements<br/>
        /// Default Value: false
        /// </param>
        /// <param name="volumeNormalization">
        /// When the project is downloaded, should the returned audio have postprocessing in order to make it compliant with audiobook normalized volume requirements<br/>
        /// Default Value: false
        /// </param>
        /// <param name="pronunciationDictionaryLocators">
        /// A list of pronunciation dictionary locators (pronunciation_dictionary_id, version_id) encoded as a list of JSON strings for pronunciation dictionaries to be applied to the text.  A list of json encoded strings is required as adding projects may occur through formData as opposed to jsonBody. To specify multiple dictionaries use multiple --form lines in your curl, such as --form 'pronunciation_dictionary_locators="{\"pronunciation_dictionary_id\":\"Vmd4Zor6fplcA7WrINey\",\"version_id\":\"hRPaxjlTdR7wFMhV4w0b\"}"' --form 'pronunciation_dictionary_locators="{\"pronunciation_dictionary_id\":\"JzWtcGQMJ6bnlWwyMo7e\",\"version_id\":\"lbmwxiLu4q6txYxgdZqn\"}"'. Note that multiple dictionaries are not currently supported by our UI which will only show the first.
        /// </param>
        /// <param name="callbackUrl">
        /// [Deprecated] A url that will be called by our service when the project is converted with a json containing the status of the conversion
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddProjectResponseModel> AddProjectV1ProjectsAddPostAsync(
            string name,
            string defaultTitleVoiceId,
            string defaultParagraphVoiceId,
            string defaultModelId,
            string? xiApiKey = default,
            string? fromUrl = default,
            byte[]? fromDocument = default,
            string? fromDocumentname = default,
            string? qualityPreset = "standard",
            string? title = default,
            string? author = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? genres = default,
            global::G.BodyAddProjectV1ProjectsAddPostTargetAudience? targetAudience = default,
            string? language = default,
            string? contentType = default,
            string? originalPublicationDate = default,
            bool? matureContent = false,
            string? isbnNumber = default,
            bool? acxVolumeNormalization = false,
            bool? volumeNormalization = false,
            global::System.Collections.Generic.IList<string>? pronunciationDictionaryLocators = default,
            string? callbackUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}