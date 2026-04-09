//HintName: G.GenerationApiClient.GetApplications.g.cs

#nullable enable

namespace G
{
    public partial class GenerationApiClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_GetApplicationsSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_GetApplicationsSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_GetApplicationsSecurityRequirement0,
            };
        partial void PrepareGetApplicationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.GetApplicationsOrder? order,
            ref global::System.Guid? before,
            ref global::System.Guid? after,
            ref int? limit,
            ref global::G.ApplicationType? type);
        partial void PrepareGetApplicationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.GetApplicationsOrder? order,
            global::System.Guid? before,
            global::System.Guid? after,
            int? limit,
            global::G.ApplicationType? type);
        partial void ProcessGetApplicationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetApplicationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List applications<br/>
        /// Retrieves a paginated list of no-code agents (formerly called no-code applications) with optional filtering and sorting capabilities.
        /// </summary>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="type">
        /// The type of no-code application.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET https://api.writer.com/v1/applications \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;"
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::G.GetApplicationsResponse> GetApplicationsAsync(
            global::G.GetApplicationsOrder? order = default,
            global::System.Guid? before = default,
            global::System.Guid? after = default,
            int? limit = default,
            global::G.ApplicationType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetApplicationsArguments(
                httpClient: HttpClient,
                order: ref order,
                before: ref before,
                after: ref after,
                limit: ref limit,
                type: ref type);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetApplicationsSecurityRequirements,
                operationName: "GetApplicationsAsync");

            var orderValue = order switch
            {
                global::G.GetApplicationsOrder.Asc => "asc",
                global::G.GetApplicationsOrder.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var typeValue = type switch
            {
                global::G.ApplicationType.Generation => "generation",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/applications",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("order", order?.ToValueString())
                .AddOptionalParameter("before", before?.ToString())
                .AddOptionalParameter("after", after?.ToString())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("type", type?.ToValueString()) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetApplicationsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                order: order,
                before: before,
                after: after,
                limit: limit,
                type: type);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetApplicationsResponse(
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
                ProcessGetApplicationsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.GetApplicationsResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.GetApplicationsResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
    }
}