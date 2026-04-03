//HintName: G.AgentsClient.AgentsCountDeployedAgents.g.cs

#nullable enable

namespace G
{
    public partial class AgentsClient
    {
        partial void PrepareAgentsCountDeployedAgentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.AgentsCountDeployedAgentsSearchItemVariant1, global::G.AgentsCountDeployedAgentsSearchItemVariant2, global::G.AgentsCountDeployedAgentsSearchItemVariant3, global::G.AgentsCountDeployedAgentsSearchItemVariant4, global::G.AgentsCountDeployedAgentsSearchItemVariant5, global::G.AgentsCountDeployedAgentsSearchItemVariant6>>? search,
            ref string? projectId,
            ref global::G.AgentsCountDeployedAgentsCombinator? combinator);
        partial void PrepareAgentsCountDeployedAgentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.AgentsCountDeployedAgentsSearchItemVariant1, global::G.AgentsCountDeployedAgentsSearchItemVariant2, global::G.AgentsCountDeployedAgentsSearchItemVariant3, global::G.AgentsCountDeployedAgentsSearchItemVariant4, global::G.AgentsCountDeployedAgentsSearchItemVariant5, global::G.AgentsCountDeployedAgentsSearchItemVariant6>>? search,
            string? projectId,
            global::G.AgentsCountDeployedAgentsCombinator? combinator);
        partial void ProcessAgentsCountDeployedAgentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAgentsCountDeployedAgentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Count Deployed Agents<br/>
        /// Count deployed agents matching search criteria
        /// </summary>
        /// <param name="search"></param>
        /// <param name="projectId"></param>
        /// <param name="combinator"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AgentsCountDeployedAgentsResponse> AgentsCountDeployedAgentsAsync(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.AgentsCountDeployedAgentsSearchItemVariant1, global::G.AgentsCountDeployedAgentsSearchItemVariant2, global::G.AgentsCountDeployedAgentsSearchItemVariant3, global::G.AgentsCountDeployedAgentsSearchItemVariant4, global::G.AgentsCountDeployedAgentsSearchItemVariant5, global::G.AgentsCountDeployedAgentsSearchItemVariant6>>? search = default,
            string? projectId = default,
            global::G.AgentsCountDeployedAgentsCombinator? combinator = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAgentsCountDeployedAgentsArguments(
                httpClient: HttpClient,
                search: search,
                projectId: ref projectId,
                combinator: ref combinator);

            var combinatorValue = combinator switch
            {
                global::G.AgentsCountDeployedAgentsCombinator.And => "AND",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/agents/search/count",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("search", search, selector: static x => x.ToString() ?? string.Empty, delimiter: ",", explode: true)
                .AddOptionalParameter("project_id", projectId)
                .AddOptionalParameter("combinator", combinator?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAgentsCountDeployedAgentsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                search: search,
                projectId: projectId,
                combinator: combinator);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAgentsCountDeployedAgentsResponse(
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
                ProcessAgentsCountDeployedAgentsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.AgentsCountDeployedAgentsResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.AgentsCountDeployedAgentsResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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