//HintName: G.DocumentsClient.SummarizeAsStream.g.cs

#nullable enable

namespace G
{
    public partial class DocumentsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_SummarizeAsStreamSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApiKeyAuth",
                        Location = "Header",
                        Name = "x-api-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };

        private static readonly global::G.EndPointSecurityRequirement s_SummarizeAsStreamSecurityRequirement1 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "OAuth2",
                        SchemeId = "OAuth2",
                        Location = "Header",
                        Name = "",
                        FriendlyName = "OAuth2",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_SummarizeAsStreamSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_SummarizeAsStreamSecurityRequirement0,
                s_SummarizeAsStreamSecurityRequirement1,
            };
        partial void PrepareSummarizeAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            ref string corpusKey,
            ref string documentId,
            global::G.SummarizeDocumentRequest request);
        partial void PrepareSummarizeAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
            string corpusKey,
            string documentId,
            global::G.SummarizeDocumentRequest request);
        partial void ProcessSummarizeAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

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
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.SummarizeDocumentStreamedResponse> SummarizeAsStreamAsync(
            string corpusKey,
            string documentId,

            global::G.SummarizeDocumentRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSummarizeAsStreamArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                corpusKey: ref corpusKey,
                documentId: ref documentId,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SummarizeAsStreamSecurityRequirements,
                operationName: "SummarizeAsStreamAsync");

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

            var __cookies = new global::System.Collections.Generic.List<string>();
            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
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
            PrepareSummarizeAsStreamRequest(
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
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                authorizations: __authorizations,
                oAuth2Coordinator: AutoSDKOAuth2State,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSummarizeAsStreamResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
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

            using var __stream = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                cancellationToken
#endif
            ).ConfigureAwait(false);

            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                .Create(__stream).EnumerateAsync(cancellationToken))
            {
                var __content = __sseEvent.Data;
                if (__content == "[DONE]")
                {
                    yield break;
                }

                var __streamedResponse = global::G.SummarizeDocumentStreamedResponse.FromJson(__content, JsonSerializerOptions) ??
                                       throw new global::G.ApiException(
                                           message: $"Response deserialization failed for \"{__content}\" ",
                                           statusCode: __response.StatusCode)
                                       {
                                           ResponseBody = __content,
                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                               __response.Headers,
                                               h => h.Key,
                                               h => h.Value),
                                       };

                yield return __streamedResponse;
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
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.SummarizeDocumentStreamedResponse> SummarizeAsStreamAsync(
            string corpusKey,
            string documentId,
            string llmName,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? promptTemplate = default,
            object? modelParameters = default,
            bool? streamResponse = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.SummarizeDocumentRequest
            {
                LlmName = llmName,
                PromptTemplate = promptTemplate,
                ModelParameters = modelParameters,
                StreamResponse = streamResponse,
            };

            var __enumerable = SummarizeAsStreamAsync(
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                corpusKey: corpusKey,
                documentId: documentId,
                request: __request,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}