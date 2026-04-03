//HintName: G.AgentsClient.ImportAgent.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class AgentsClient
    {
        partial void PrepareImportAgentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xOverrideEmbeddingModel,
            global::G.BodyImportAgent request);
        partial void PrepareImportAgentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xOverrideEmbeddingModel,
            global::G.BodyImportAgent request);
        partial void ProcessImportAgentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessImportAgentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Import Agent<br/>
        /// Import a serialized agent file and recreate the agent(s) in the system.<br/>
        /// Returns the IDs of all imported agents.
        /// </summary>
        /// <param name="xOverrideEmbeddingModel"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ImportedAgentsResponse> ImportAgentAsync(

            global::G.BodyImportAgent request,
            string? xOverrideEmbeddingModel = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareImportAgentArguments(
                httpClient: HttpClient,
                xOverrideEmbeddingModel: ref xOverrideEmbeddingModel,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/agents/import",
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

            if (xOverrideEmbeddingModel != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-override-embedding-model", xOverrideEmbeddingModel.ToString());
            }

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (xOverrideEmbeddingModel != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{xOverrideEmbeddingModel}"),
                    name: "\"x-override-embedding-model\"");
            }
            var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentFile,
                name: "\"file\"",
                fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
            if (__contentFile.Headers.ContentDisposition != null)
            {
                __contentFile.Headers.ContentDisposition.FileNameStar = null;
            }
            if (request.OverrideExistingTools != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OverrideExistingTools}"),
                    name: "\"override_existing_tools\"");
            } 
            if (request.StripMessages != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.StripMessages}"),
                    name: "\"strip_messages\"");
            } 
            if (request.Secrets != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Secrets}"),
                    name: "\"secrets\"");
            } 
            if (request.Name != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Name}"),
                    name: "\"name\"");
            } 
            if (request.Embedding != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Embedding}"),
                    name: "\"embedding\"");
            } 
            if (request.Model != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Model}"),
                    name: "\"model\"");
            } 
            if (request.AppendCopySuffix != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AppendCopySuffix}"),
                    name: "\"append_copy_suffix\"");
            } 
            if (request.OverrideName != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OverrideName}"),
                    name: "\"override_name\"");
            } 
            if (request.OverrideEmbeddingHandle != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OverrideEmbeddingHandle}"),
                    name: "\"override_embedding_handle\"");
            } 
            if (request.OverrideModelHandle != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OverrideModelHandle}"),
                    name: "\"override_model_handle\"");
            } 
            if (request.ProjectId != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ProjectId}"),
                    name: "\"project_id\"");
            } 
            if (request.EnvVarsJson != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.EnvVarsJson}"),
                    name: "\"env_vars_json\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareImportAgentRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xOverrideEmbeddingModel: xOverrideEmbeddingModel,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessImportAgentResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
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
                ProcessImportAgentResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ImportedAgentsResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ImportedAgentsResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Import Agent<br/>
        /// Import a serialized agent file and recreate the agent(s) in the system.<br/>
        /// Returns the IDs of all imported agents.
        /// </summary>
        /// <param name="xOverrideEmbeddingModel"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="overrideExistingTools">
        /// If set to True, existing tools can get their source code overwritten by the uploaded tool definitions. Note that Letta core tools can never be updated externally.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="stripMessages">
        /// If set to True, strips all messages from the agent before importing.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="secrets">
        /// Secrets as a JSON string to pass to the agent for tool execution.
        /// </param>
        /// <param name="name">
        /// If provided, overrides the agent name with this value.
        /// </param>
        /// <param name="embedding">
        /// Embedding handle to override with.
        /// </param>
        /// <param name="model">
        /// Model handle to override the agent's default model. This allows the imported agent to use a different model while keeping other defaults (e.g., context size) from the original configuration.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ImportedAgentsResponse> ImportAgentAsync(
            byte[] file,
            string filename,
            string? xOverrideEmbeddingModel = default,
            bool? overrideExistingTools = default,
            bool? stripMessages = default,
            string? secrets = default,
            string? name = default,
            string? embedding = default,
            string? model = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyImportAgent
            {
                File = file,
                Filename = filename,
                OverrideExistingTools = overrideExistingTools,
                StripMessages = stripMessages,
                Secrets = secrets,
                Name = name,
                Embedding = embedding,
                Model = model,
            };

            return await ImportAgentAsync(
                xOverrideEmbeddingModel: xOverrideEmbeddingModel,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}