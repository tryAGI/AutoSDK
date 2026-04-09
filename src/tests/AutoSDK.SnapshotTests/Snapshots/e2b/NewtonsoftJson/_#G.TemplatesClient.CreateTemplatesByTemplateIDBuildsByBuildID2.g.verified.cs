//HintName: G.TemplatesClient.CreateTemplatesByTemplateIDBuildsByBuildID2.g.cs

#nullable enable

namespace G
{
    public partial class TemplatesClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_CreateTemplatesByTemplateIDBuildsByBuildID2SecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "X-API-Key",
                        FriendlyName = "ApiKeyAuth",
                    },
                },
            };

        private static readonly global::G.EndPointSecurityRequirement s_CreateTemplatesByTemplateIDBuildsByBuildID2SecurityRequirement1 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "X-Supabase-Team",
                        FriendlyName = "Supabase2TeamAuth",
                    },
                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "X-Supabase-Token",
                        FriendlyName = "Supabase1TokenAuth",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_CreateTemplatesByTemplateIDBuildsByBuildID2SecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_CreateTemplatesByTemplateIDBuildsByBuildID2SecurityRequirement0,
                s_CreateTemplatesByTemplateIDBuildsByBuildID2SecurityRequirement1,
            };
        partial void PrepareCreateTemplatesByTemplateIDBuildsByBuildID2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string templateID,
            ref string buildID,
            global::G.TemplateBuildStartV2 request);
        partial void PrepareCreateTemplatesByTemplateIDBuildsByBuildID2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string templateID,
            string buildID,
            global::G.TemplateBuildStartV2 request);
        partial void ProcessCreateTemplatesByTemplateIDBuildsByBuildID2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Start the build
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="buildID"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task CreateTemplatesByTemplateIDBuildsByBuildID2Async(
            string templateID,
            string buildID,

            global::G.TemplateBuildStartV2 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateTemplatesByTemplateIDBuildsByBuildID2Arguments(
                httpClient: HttpClient,
                templateID: ref templateID,
                buildID: ref buildID,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateTemplatesByTemplateIDBuildsByBuildID2SecurityRequirements,
                operationName: "CreateTemplatesByTemplateIDBuildsByBuildID2Async");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v2/templates/{templateID}/builds/{buildID}",
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateTemplatesByTemplateIDBuildsByBuildID2Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                templateID: templateID,
                buildID: buildID,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateTemplatesByTemplateIDBuildsByBuildID2Response(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Authentication error
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.Error? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.Error.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.Error.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Server error
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::G.Error? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::G.Error.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::G.Error.FromJson(__content_500, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
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

                try
                {
                    __response.EnsureSuccessStatusCode();

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
        /// Start the build
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="buildID"></param>
        /// <param name="fromImage">
        /// Image to use as a base for the template build
        /// </param>
        /// <param name="fromTemplate">
        /// Template to use as a base for the template build
        /// </param>
        /// <param name="fromImageRegistry"></param>
        /// <param name="force">
        /// Whether the whole build should be forced to run regardless of the cache<br/>
        /// Default Value: false
        /// </param>
        /// <param name="steps">
        /// List of steps to execute in the template build<br/>
        /// Default Value: []
        /// </param>
        /// <param name="startCmd">
        /// Start command to execute in the template after the build
        /// </param>
        /// <param name="readyCmd">
        /// Ready check command to execute in the template after the build
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateTemplatesByTemplateIDBuildsByBuildID2Async(
            string templateID,
            string buildID,
            string? fromImage = default,
            string? fromTemplate = default,
            global::G.FromImageRegistry? fromImageRegistry = default,
            bool? force = default,
            global::System.Collections.Generic.IList<global::G.TemplateStep>? steps = default,
            string? startCmd = default,
            string? readyCmd = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.TemplateBuildStartV2
            {
                FromImage = fromImage,
                FromTemplate = fromTemplate,
                FromImageRegistry = fromImageRegistry,
                Force = force,
                Steps = steps,
                StartCmd = startCmd,
                ReadyCmd = readyCmd,
            };

            await CreateTemplatesByTemplateIDBuildsByBuildID2Async(
                templateID: templateID,
                buildID: buildID,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}