//HintName: G.Api.TunedModelsCreate.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareTunedModelsCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? tunedModelId,
            global::G.TunedModel request);
        partial void PrepareTunedModelsCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? tunedModelId,
            global::G.TunedModel request);
        partial void ProcessTunedModelsCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTunedModelsCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creates a tuned model. Check intermediate tuning progress (if any) through the [google.longrunning.Operations] service. Access status and results through the Operations service. Example: GET /v1/tunedModels/az2mb0bpw6i/operations/000-111-222
        /// </summary>
        /// <param name="tunedModelId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Operation> TunedModelsCreateAsync(

            global::G.TunedModel request,
            string? tunedModelId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTunedModelsCreateArguments(
                httpClient: HttpClient,
                tunedModelId: ref tunedModelId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/tunedModels",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("tunedModelId", tunedModelId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTunedModelsCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                tunedModelId: tunedModelId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTunedModelsCreateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

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
                ProcessTunedModelsCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.Operation.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.Operation.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Creates a tuned model. Check intermediate tuning progress (if any) through the [google.longrunning.Operations] service. Access status and results through the Operations service. Example: GET /v1/tunedModels/az2mb0bpw6i/operations/000-111-222
        /// </summary>
        /// <param name="tunedModelId"></param>
        /// <param name="tunedModelSource">
        /// Tuned model as a source for training a new model.
        /// </param>
        /// <param name="baseModel">
        /// Immutable. The name of the `Model` to tune. Example: `models/gemini-1.5-flash-001`
        /// </param>
        /// <param name="displayName">
        /// Optional. The name to display for this model in user interfaces. The display name must be up to 40 characters including spaces.
        /// </param>
        /// <param name="description">
        /// Optional. A short description of this model.
        /// </param>
        /// <param name="temperature">
        /// Optional. Controls the randomness of the output. Values can range over `[0.0,1.0]`, inclusive. A value closer to `1.0` will produce responses that are more varied, while a value closer to `0.0` will typically result in less surprising responses from the model. This value specifies default to be the one used by the base model while creating the model.
        /// </param>
        /// <param name="topP">
        /// Optional. For Nucleus sampling. Nucleus sampling considers the smallest set of tokens whose probability sum is at least `top_p`. This value specifies default to be the one used by the base model while creating the model.
        /// </param>
        /// <param name="topK">
        /// Optional. For Top-k sampling. Top-k sampling considers the set of `top_k` most probable tokens. This value specifies default to be used by the backend while making the call to the model. This value specifies default to be the one used by the base model while creating the model.
        /// </param>
        /// <param name="tuningTask">
        /// Tuning tasks that create tuned models.
        /// </param>
        /// <param name="readerProjectNumbers">
        /// Optional. List of project numbers that have read access to the tuned model.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Operation> TunedModelsCreateAsync(
            string? tunedModelId = default,
            global::G.TunedModelSource? tunedModelSource = default,
            string? baseModel = default,
            string? displayName = default,
            string? description = default,
            float? temperature = default,
            float? topP = default,
            int? topK = default,
            global::G.TuningTask? tuningTask = default,
            global::System.Collections.Generic.IList<string>? readerProjectNumbers = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.TunedModel
            {
                TunedModelSource = tunedModelSource,
                BaseModel = baseModel,
                DisplayName = displayName,
                Description = description,
                Temperature = temperature,
                TopP = topP,
                TopK = topK,
                TuningTask = tuningTask,
                ReaderProjectNumbers = readerProjectNumbers,
            };

            return await TunedModelsCreateAsync(
                tunedModelId: tunedModelId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}