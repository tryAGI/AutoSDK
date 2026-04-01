//HintName: G.CorporaClient.Create.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class CorporaClient
    {
        partial void PrepareCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            global::G.CreateCorpusRequest request);
        partial void PrepareCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
            global::G.CreateCorpusRequest request);
        partial void ProcessCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a corpus<br/>
        /// The Create Corpus API lets you create a corpus to store and manage your documents. A corpus is a container for documents and their associated metadata. When creating a corpus, you can specify various settings such as the corpus key, name, description, encoder, and filter attributes.<br/>
        /// ## Corpus object<br/>
        /// When you create a `corpus` object, the `corpus_key` property is required to uniquely identify the corpus. The `name` parameter is optional and defaults to the value of `key`. The optional `description` properties lets you provide additional information about the corpus. When creating a new corpus, you also have the flexibility to specify a custom `corpus_key` that follows a naming convention of your choice. This allows you to assign easily identifiable keys to your corpora, making it easier to manage and reference them in your application.<br/>
        /// You can specify whether to treat queries or documents in the corpus as questions or answers using the `queries_are_answers` and `documents_are_questions` boolean properties. These settings affect the semantics of the encoder used at query time and indexing time.<br/>
        /// ## Add metadata as filter attributes<br/>
        /// When creating a corpus with this endpoint or the Vectara Console, you define metadata fields using the `filter_attributes` object. This ensures the corpus supports filtering on specific metadata attributes, either at the document level or the part level.<br/>
        /// Filter attributes enable you to attach metadata to your data at the document (`doc`) or `part` level, which you can use later in filter expressions to narrow the scope of your queries. A filter attribute must specify a unique `name` (up to 64 characters long), and a `level` which indicates whether it exists in the `doc` or `part` level metadata. At indexing time, metadata with this name is extracted and made available for filter expressions to operate on. [Learn more](https://docs.vectara.com/docs/build/prepare-data/metadata-filters)<br/>
        /// ### Doc and part filter levels<br/>
        /// The `doc` attribute applies to the entire document. Use this for metadata that is consistent across the whole document, such as author, publication date, and document ID.<br/>
        /// The `part` attribute applies to specific sections or chunks within a document. Use for metadata that may vary within different parts of the document, such as sections, page numbers, and sentiment scores.<br/>
        /// If `indexed` is true, the system will build an index on the extracted values to further improve the performance of filter expressions involving the attribute.<br/>
        /// Filter attributes must specify a `type`, which is validated when documents are indexed. The four supported types are `integer`, which stores signed whole-number values up to eight bytes in length; `real`, for storing floating point values in [IEEE 754 8-byte format]; `text` for storing textual strings in [UTF-8 encoding], and `boolean` for storing true/false values.<br/>
        /// After you define filter attributes, you can use them within your queries. For example:<br/>
        /// * Document-level attribute: `doc.publication_year &gt; 2020`<br/>
        /// * Part-level attribute: `part.sentiment_score &gt; 0.7`<br/>
        /// ## Custom dimensions <br/>
        /// Custom dimensions let you add additional context to your data that contain user-defined values in addition to what Vectara automatically extracts and stores from the text. For example, *upvotes* can be a custom dimension. For example, see [Add custom dimensions to boost content](/docs/tutorials/add-custom-dimensions)."
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Corpus> CreateAsync(

            global::G.CreateCorpusRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/corpora",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
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
            PrepareCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid request body in the create corpus request.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.BadRequestError? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.BadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.BadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.BadRequestError>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Permissions do not allow creating a corpus.
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
            // The corpus already exists
            if ((int)__response.StatusCode == 409)
            {
                string? __content_409 = null;
                global::System.Exception? __exception_409 = null;
                global::G.Error? __value_409 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_409 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_409 = global::G.Error.FromJson(__content_409, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_409 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_409 = global::G.Error.FromJson(__content_409, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_409 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_409 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_409,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_409,
                    ResponseObject = __value_409,
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
                ProcessCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.Corpus.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.Corpus.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create a corpus<br/>
        /// The Create Corpus API lets you create a corpus to store and manage your documents. A corpus is a container for documents and their associated metadata. When creating a corpus, you can specify various settings such as the corpus key, name, description, encoder, and filter attributes.<br/>
        /// ## Corpus object<br/>
        /// When you create a `corpus` object, the `corpus_key` property is required to uniquely identify the corpus. The `name` parameter is optional and defaults to the value of `key`. The optional `description` properties lets you provide additional information about the corpus. When creating a new corpus, you also have the flexibility to specify a custom `corpus_key` that follows a naming convention of your choice. This allows you to assign easily identifiable keys to your corpora, making it easier to manage and reference them in your application.<br/>
        /// You can specify whether to treat queries or documents in the corpus as questions or answers using the `queries_are_answers` and `documents_are_questions` boolean properties. These settings affect the semantics of the encoder used at query time and indexing time.<br/>
        /// ## Add metadata as filter attributes<br/>
        /// When creating a corpus with this endpoint or the Vectara Console, you define metadata fields using the `filter_attributes` object. This ensures the corpus supports filtering on specific metadata attributes, either at the document level or the part level.<br/>
        /// Filter attributes enable you to attach metadata to your data at the document (`doc`) or `part` level, which you can use later in filter expressions to narrow the scope of your queries. A filter attribute must specify a unique `name` (up to 64 characters long), and a `level` which indicates whether it exists in the `doc` or `part` level metadata. At indexing time, metadata with this name is extracted and made available for filter expressions to operate on. [Learn more](https://docs.vectara.com/docs/build/prepare-data/metadata-filters)<br/>
        /// ### Doc and part filter levels<br/>
        /// The `doc` attribute applies to the entire document. Use this for metadata that is consistent across the whole document, such as author, publication date, and document ID.<br/>
        /// The `part` attribute applies to specific sections or chunks within a document. Use for metadata that may vary within different parts of the document, such as sections, page numbers, and sentiment scores.<br/>
        /// If `indexed` is true, the system will build an index on the extracted values to further improve the performance of filter expressions involving the attribute.<br/>
        /// Filter attributes must specify a `type`, which is validated when documents are indexed. The four supported types are `integer`, which stores signed whole-number values up to eight bytes in length; `real`, for storing floating point values in [IEEE 754 8-byte format]; `text` for storing textual strings in [UTF-8 encoding], and `boolean` for storing true/false values.<br/>
        /// After you define filter attributes, you can use them within your queries. For example:<br/>
        /// * Document-level attribute: `doc.publication_year &gt; 2020`<br/>
        /// * Part-level attribute: `part.sentiment_score &gt; 0.7`<br/>
        /// ## Custom dimensions <br/>
        /// Custom dimensions let you add additional context to your data that contain user-defined values in addition to what Vectara automatically extracts and stores from the text. For example, *upvotes* can be a custom dimension. For example, see [Add custom dimensions to boost content](/docs/tutorials/add-custom-dimensions)."
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="key">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="name">
        /// The name for the corpus. This value defaults to the key.<br/>
        /// Example: My corpus
        /// </param>
        /// <param name="description">
        /// Description of the corpus.<br/>
        /// Example: Documents with important information for my prompt.
        /// </param>
        /// <param name="saveHistory">
        /// Indicates whether to save corpus queries to query history by default.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="queriesAreAnswers">
        /// Queries made to this corpus are considered answers, and not questions.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="documentsAreQuestions">
        /// Documents inside this corpus are considered questions, and not answers.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="encoderName">
        /// The encoder used by the corpus, `boomerang-2023-q3`.<br/>
        /// Example: boomerang-2023-q3
        /// </param>
        /// <param name="filterAttributes">
        /// The new filter attributes of the corpus. If unset then the corpus will not have filter attributes.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="customDimensions">
        /// A custom dimension is an additional numerical field attached to a document part. You can then multiply this numerical field with a query time custom dimension of the same name. This allows boosting (or burying) document parts for arbitrary reasons. This feature is only enabled for Pro and Enterprise customers.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Corpus> CreateAsync(
            string key,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? name = default,
            string? description = default,
            bool? saveHistory = default,
            bool? queriesAreAnswers = default,
            bool? documentsAreQuestions = default,
            string? encoderName = default,
            global::System.Collections.Generic.IList<global::G.FilterAttribute>? filterAttributes = default,
            global::System.Collections.Generic.IList<global::G.CorpusCustomDimension>? customDimensions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateCorpusRequest
            {
                Key = key,
                Name = name,
                Description = description,
                SaveHistory = saveHistory,
                QueriesAreAnswers = queriesAreAnswers,
                DocumentsAreQuestions = documentsAreQuestions,
                EncoderName = encoderName,
                FilterAttributes = filterAttributes,
                CustomDimensions = customDimensions,
            };

            return await CreateAsync(
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}