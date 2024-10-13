//HintName: G.ProjectsClient.AddProjectV1ProjectsAddPost.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        partial void PrepareAddProjectV1ProjectsAddPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xiApiKey,
            global::G.BodyAddProjectV1ProjectsAddPost request);
        partial void PrepareAddProjectV1ProjectsAddPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xiApiKey,
            global::G.BodyAddProjectV1ProjectsAddPost request);
        partial void ProcessAddProjectV1ProjectsAddPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAddProjectV1ProjectsAddPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::G.AddProjectResponseModel> AddProjectV1ProjectsAddPostAsync(
            global::G.BodyAddProjectV1ProjectsAddPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareAddProjectV1ProjectsAddPostArguments(
                httpClient: _httpClient,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/projects/add",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xiApiKey != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (xiApiKey != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{xiApiKey}"),
                    name: "xi-api-key");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Name}"),
                name: "name");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.DefaultTitleVoiceId}"),
                name: "default_title_voice_id");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.DefaultParagraphVoiceId}"),
                name: "default_paragraph_voice_id");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.DefaultModelId}"),
                name: "default_model_id");
            if (request.FromUrl != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.FromUrl}"),
                    name: "from_url");
            } 
            if (request.FromDocument != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.FromDocument ?? global::System.Array.Empty<byte>())
                    {
                        Headers =
                        {
                            ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data"),
                        },
                    },
                    name: "from_document",
                    fileName: request.FromDocumentname ?? string.Empty);
            } 
            if (request.QualityPreset != "standard")
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.QualityPreset}"),
                    name: "quality_preset");
            } 
            if (request.Title != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Title}"),
                    name: "title");
            } 
            if (request.Author != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Author}"),
                    name: "author");
            } 
            if (request.Description != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Description}"),
                    name: "description");
            } 
            if (request.Genres != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.Genres, x => x))}]"),
                    name: "genres");
            } 
            if (request.TargetAudience != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TargetAudience?.ToValueString()}"),
                    name: "target_audience");
            } 
            if (request.Language != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Language}"),
                    name: "language");
            } 
            if (request.ContentType != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ContentType}"),
                    name: "content_type");
            } 
            if (request.OriginalPublicationDate != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OriginalPublicationDate}"),
                    name: "original_publication_date");
            } 
            if (request.MatureContent != false)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.MatureContent}"),
                    name: "mature_content");
            } 
            if (request.IsbnNumber != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.IsbnNumber}"),
                    name: "isbn_number");
            } 
            if (request.AcxVolumeNormalization != false)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AcxVolumeNormalization}"),
                    name: "acx_volume_normalization");
            } 
            if (request.VolumeNormalization != false)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VolumeNormalization}"),
                    name: "volume_normalization");
            } 
            if (request.PronunciationDictionaryLocators != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.PronunciationDictionaryLocators, x => x))}]"),
                    name: "pronunciation_dictionary_locators");
            } 
            if (request.CallbackUrl != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.CallbackUrl}"),
                    name: "callback_url");
            }
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAddProjectV1ProjectsAddPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                xiApiKey: xiApiKey,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAddProjectV1ProjectsAddPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAddProjectV1ProjectsAddPostResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::G.AddProjectResponseModel.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

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
        public async global::System.Threading.Tasks.Task<global::G.AddProjectResponseModel> AddProjectV1ProjectsAddPostAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.BodyAddProjectV1ProjectsAddPost
            {
                Name = name,
                DefaultTitleVoiceId = defaultTitleVoiceId,
                DefaultParagraphVoiceId = defaultParagraphVoiceId,
                DefaultModelId = defaultModelId,
                FromUrl = fromUrl,
                FromDocument = fromDocument,
                FromDocumentname = fromDocumentname,
                QualityPreset = qualityPreset,
                Title = title,
                Author = author,
                Description = description,
                Genres = genres,
                TargetAudience = targetAudience,
                Language = language,
                ContentType = contentType,
                OriginalPublicationDate = originalPublicationDate,
                MatureContent = matureContent,
                IsbnNumber = isbnNumber,
                AcxVolumeNormalization = acxVolumeNormalization,
                VolumeNormalization = volumeNormalization,
                PronunciationDictionaryLocators = pronunciationDictionaryLocators,
                CallbackUrl = callbackUrl,
            };

            return await AddProjectV1ProjectsAddPostAsync(
                xiApiKey: xiApiKey,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}