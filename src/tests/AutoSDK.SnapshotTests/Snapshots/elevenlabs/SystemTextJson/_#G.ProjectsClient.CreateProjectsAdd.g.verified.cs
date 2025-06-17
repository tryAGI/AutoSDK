﻿//HintName: G.ProjectsClient.CreateProjectsAdd.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {
        partial void PrepareCreateProjectsAddArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xiApiKey,
            global::G.BodyAddProjectV1ProjectsAddPost request);
        partial void PrepareCreateProjectsAddRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xiApiKey,
            global::G.BodyAddProjectV1ProjectsAddPost request);
        partial void ProcessCreateProjectsAddResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateProjectsAddResponseContent(
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
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::G.AddProjectResponseModel> CreateProjectsAddAsync(
            global::G.BodyAddProjectV1ProjectsAddPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateProjectsAddArguments(
                httpClient: HttpClient,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/projects/add",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
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
                    content: new global::System.Net.Http.ByteArrayContent(request.FromDocument ?? global::System.Array.Empty<byte>()),
                    name: "from_document",
                    fileName: request.FromDocumentname ?? string.Empty);
            } 
            if (request.QualityPreset != default)
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
            if (request.MatureContent != default)
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
            if (request.AcxVolumeNormalization != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AcxVolumeNormalization}"),
                    name: "acx_volume_normalization");
            } 
            if (request.VolumeNormalization != default)
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
            if (request.Fiction != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Fiction?.ToValueString()}"),
                    name: "fiction");
            } 
            if (request.ApplyTextNormalization != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ApplyTextNormalization?.ToValueString()}"),
                    name: "apply_text_normalization");
            } 
            if (request.AutoConvert != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AutoConvert}"),
                    name: "auto_convert");
            } 
            if (request.AutoAssignVoices != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AutoAssignVoices}"),
                    name: "auto_assign_voices");
            } 
            if (request.SourceType != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SourceType?.ToValueString()}"),
                    name: "source_type");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateProjectsAddRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xiApiKey: xiApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateProjectsAddResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::G.HTTPValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateProjectsAddResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.AddProjectResponseModel.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.AddProjectResponseModel.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }

        /// <summary>
        /// Add Project<br/>
        /// Creates a new project, it can be either initialized as blank, from a document or from a URL.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::G.AddProjectResponseModel> CreateProjectsAddAsync(
            string name,
            string defaultTitleVoiceId,
            string defaultParagraphVoiceId,
            string defaultModelId,
            string? xiApiKey = default,
            string? fromUrl = default,
            byte[]? fromDocument = default,
            string? fromDocumentname = default,
            string? qualityPreset = default,
            string? title = default,
            string? author = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? genres = default,
            global::G.BodyAddProjectV1ProjectsAddPostTargetAudience? targetAudience = default,
            string? language = default,
            string? contentType = default,
            string? originalPublicationDate = default,
            bool? matureContent = default,
            string? isbnNumber = default,
            bool? acxVolumeNormalization = default,
            bool? volumeNormalization = default,
            global::System.Collections.Generic.IList<string>? pronunciationDictionaryLocators = default,
            string? callbackUrl = default,
            global::G.BodyAddProjectV1ProjectsAddPostFiction? fiction = default,
            global::G.BodyAddProjectV1ProjectsAddPostApplyTextNormalization? applyTextNormalization = default,
            bool? autoConvert = default,
            bool? autoAssignVoices = default,
            global::G.BodyAddProjectV1ProjectsAddPostSourceType? sourceType = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyAddProjectV1ProjectsAddPost
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
                Fiction = fiction,
                ApplyTextNormalization = applyTextNormalization,
                AutoConvert = autoConvert,
                AutoAssignVoices = autoAssignVoices,
                SourceType = sourceType,
            };

            return await CreateProjectsAddAsync(
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}