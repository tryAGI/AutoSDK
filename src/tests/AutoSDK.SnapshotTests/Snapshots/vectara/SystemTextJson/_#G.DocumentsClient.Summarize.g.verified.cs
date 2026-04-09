//HintName: G.DocumentsClient.Summarize.g.cs

#nullable enable

namespace G
{
    public partial class DocumentsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_SummarizeSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "x-api-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };

        private static readonly global::G.EndPointSecurityRequirement s_SummarizeSecurityRequirement1 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "OAuth2",
                        Location = "Header",
                        Name = "",
                        FriendlyName = "OAuth2",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_SummarizeSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_SummarizeSecurityRequirement0,
                s_SummarizeSecurityRequirement1,
            };
        partial void PrepareSummarizeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            ref string corpusKey,
            ref string documentId,
            global::G.SummarizeDocumentRequest request);
        partial void PrepareSummarizeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
            string corpusKey,
            string documentId,
            global::G.SummarizeDocumentRequest request);
        partial void ProcessSummarizeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSummarizeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Summarize a document<br/>
        /// Organizations often struggle with extracting relevant insights from extensive documentation, such as vendor quotes, financial statements, and technical reports. Manually reviewing these documents is both time-consuming and prone to errors. <br/>
        /// The tech preview of the Documentation Summarization API enables users to generate concise summaries that capture essential insights from single documents without having to process entire documents manually. Efficiently process large documents, extract key insights, and interact with real-time data summaries.<br/>
        /// * Enable streaming for large documents to receive summaries incrementally.<br/>
        /// * Customize `prompt_template` to fine-tune summary output for specific domains.<br/>
        /// * Use standard responses for small documents where streaming is unnecessary.<br/>
        /// * Monitor streaming events to track the progress of real-time summarization.<br/>
        /// :::note<br/>
        /// The documentation length is limited by the context window of your selected LLM.<br/>
        /// :::<br/>
        /// ## Response formats<br/>
        /// The API supports two response modes:<br/>
        /// * **Standard**: Provides a complete summary in one response.<br/>
        /// * **Streaming** Provides incremental responses using Server-Sent Events (SSE).<br/>
        /// ### Non-streaming response<br/>
        /// In standard mode, the API returns a structured response containing the complete summary of the document. The summary field contains the generated text, enabling users to extract essential information quickly.<br/>
        /// ### Streaming response<br/>
        /// For streaming responses, the API returns Server-Sent Events (SSE). The first event begins streaming partial results as soon as they are available, while the final event marks the end of the summarization process.<br/>
        /// The streamed response consists of multiple events:<br/>
        /// * `generation_info`: Contains the `rendered_prompt` which is the compiled prompt sent to the LLM for document summarization.<br/>
        /// * `generation_chunk`: Returns partial chunk of the generated summary.<br/>
        /// * `generation_end`: Marks the completion of the summary generation.<br/>
        /// * `error`: Returns an error message if summarization fails.<br/>
        /// * `end`: Indicates the end of the streaming session.<br/>
        /// ## Prompt template example<br/>
        /// When crafting a prompt, you can access your document with the `$vectaraDocument` field. This example shows a simple prompt:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "role": "user",<br/>
        ///   "content": "Summarize the document: \$vectaraDocument.json()"<br/>
        /// }<br/>
        /// ```<br/>
        /// The document also has the following methods to support custom prompts. <br/>
        /// * `$vectaraDocument.json()`: Provides a JSON representation of the whole document.<br/>
        /// * `$vectaraDocument.id()`: Specifies the unique identifier of the document (`document_id`)<br/>
        /// * `$vectaraDocument.metadata()`: Specifies metadata from the document.  <br/>
        ///   For example, <br/>
        ///   `$vectaraDocument.metadata().get("key")` retrieves a specific metadata value by key.<br/>
        /// * `$vectaraDocument.parts()`: Returns an array of document parts which you can look through.  <br/>
        ///   For example, `#foreach ($part in $vectaraDocument.parts())`.  <br/>
        /// * `$part.text()`: Retrieves the text of the part.<br/>
        /// * `$part.metadata()`: Retrieves metadata of a part.<br/>
        /// * `$part.hasTable()`: Determines if the part contains a table.<br/>
        /// * `$part.table()`: Provides access to the table within the part. For example, use `$part.table().json()` to retrieve the table in JSON format.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SummarizeDocumentResponse> SummarizeAsync(
            string corpusKey,
            string documentId,

            global::G.SummarizeDocumentRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSummarizeArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                corpusKey: ref corpusKey,
                documentId: ref documentId,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SummarizeSecurityRequirements,
                operationName: "SummarizeAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v2/corpora/{corpusKey}/documents/{documentId}/summarize",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            if (requestTimeout != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Request-Timeout", requestTimeout.ToString());
            }
            if (requestTimeoutMillis != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Request-Timeout-Millis", requestTimeoutMillis.ToString());
            }

            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareSummarizeRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                corpusKey: corpusKey,
                documentId: documentId,
                request: request);

            using var __response = await global::G.Api.AutoSDKOAuth2Helpers.SendAsync(
                httpClient: HttpClient,
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                authorizations: __authorizations,
                oAuth2Coordinator: AutoSDKOAuth2State,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSummarizeResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Permissions do not allow summarizing a document in the corpus.
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::G.Error? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::G.Error.FromJson(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::G.Error.FromJson(__content_403, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Corpus or document not found.
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::G.NotFoundError? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::G.NotFoundError.FromJson(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::G.NotFoundError.FromJson(__content_404, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException<global::G.NotFoundError>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
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
                ProcessSummarizeResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.SummarizeDocumentResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.SummarizeDocumentResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

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
        }
        /// <summary>
        /// Summarize a document<br/>
        /// Organizations often struggle with extracting relevant insights from extensive documentation, such as vendor quotes, financial statements, and technical reports. Manually reviewing these documents is both time-consuming and prone to errors. <br/>
        /// The tech preview of the Documentation Summarization API enables users to generate concise summaries that capture essential insights from single documents without having to process entire documents manually. Efficiently process large documents, extract key insights, and interact with real-time data summaries.<br/>
        /// * Enable streaming for large documents to receive summaries incrementally.<br/>
        /// * Customize `prompt_template` to fine-tune summary output for specific domains.<br/>
        /// * Use standard responses for small documents where streaming is unnecessary.<br/>
        /// * Monitor streaming events to track the progress of real-time summarization.<br/>
        /// :::note<br/>
        /// The documentation length is limited by the context window of your selected LLM.<br/>
        /// :::<br/>
        /// ## Response formats<br/>
        /// The API supports two response modes:<br/>
        /// * **Standard**: Provides a complete summary in one response.<br/>
        /// * **Streaming** Provides incremental responses using Server-Sent Events (SSE).<br/>
        /// ### Non-streaming response<br/>
        /// In standard mode, the API returns a structured response containing the complete summary of the document. The summary field contains the generated text, enabling users to extract essential information quickly.<br/>
        /// ### Streaming response<br/>
        /// For streaming responses, the API returns Server-Sent Events (SSE). The first event begins streaming partial results as soon as they are available, while the final event marks the end of the summarization process.<br/>
        /// The streamed response consists of multiple events:<br/>
        /// * `generation_info`: Contains the `rendered_prompt` which is the compiled prompt sent to the LLM for document summarization.<br/>
        /// * `generation_chunk`: Returns partial chunk of the generated summary.<br/>
        /// * `generation_end`: Marks the completion of the summary generation.<br/>
        /// * `error`: Returns an error message if summarization fails.<br/>
        /// * `end`: Indicates the end of the streaming session.<br/>
        /// ## Prompt template example<br/>
        /// When crafting a prompt, you can access your document with the `$vectaraDocument` field. This example shows a simple prompt:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "role": "user",<br/>
        ///   "content": "Summarize the document: \$vectaraDocument.json()"<br/>
        /// }<br/>
        /// ```<br/>
        /// The document also has the following methods to support custom prompts. <br/>
        /// * `$vectaraDocument.json()`: Provides a JSON representation of the whole document.<br/>
        /// * `$vectaraDocument.id()`: Specifies the unique identifier of the document (`document_id`)<br/>
        /// * `$vectaraDocument.metadata()`: Specifies metadata from the document.  <br/>
        ///   For example, <br/>
        ///   `$vectaraDocument.metadata().get("key")` retrieves a specific metadata value by key.<br/>
        /// * `$vectaraDocument.parts()`: Returns an array of document parts which you can look through.  <br/>
        ///   For example, `#foreach ($part in $vectaraDocument.parts())`.  <br/>
        /// * `$part.text()`: Retrieves the text of the part.<br/>
        /// * `$part.metadata()`: Retrieves metadata of a part.<br/>
        /// * `$part.hasTable()`: Determines if the part contains a table.<br/>
        /// * `$part.table()`: Provides access to the table within the part. For example, use `$part.table().json()` to retrieve the table in JSON format.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="documentId"></param>
        /// <param name="llmName">
        /// The name of the LLM.<br/>
        /// Example: mockingbird-2.0
        /// </param>
        /// <param name="promptTemplate">
        /// The prompt template to use when generating the summary. Vectara manages both system and user roles and prompts for the generative LLM out of the box by default. However, users can override the `prompt_template` via this variable. The `prompt_template` is in the form of an Apache Velocity template. For more details on how to configure the `prompt_template`, see the [long-form documentation](https://docs.vectara.com/docs/prompts/vectara-prompt-engine).<br/>
        /// Example: Provide a concise summary of the document.
        /// </param>
        /// <param name="modelParameters">
        /// Optional parameters for the specified model used when generating the summary.
        /// </param>
        /// <param name="streamResponse">
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SummarizeDocumentResponse> SummarizeAsync(
            string corpusKey,
            string documentId,
            string llmName,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? promptTemplate = default,
            object? modelParameters = default,
            bool? streamResponse = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.SummarizeDocumentRequest
            {
                LlmName = llmName,
                PromptTemplate = promptTemplate,
                ModelParameters = modelParameters,
                StreamResponse = streamResponse,
            };

            return await SummarizeAsync(
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                corpusKey: corpusKey,
                documentId: documentId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}