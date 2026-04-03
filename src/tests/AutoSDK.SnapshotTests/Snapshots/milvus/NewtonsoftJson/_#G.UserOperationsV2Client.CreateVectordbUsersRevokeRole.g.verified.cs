//HintName: G.UserOperationsV2Client.CreateVectordbUsersRevokeRole.g.cs

#nullable enable

namespace G
{
    public partial class UserOperationsV2Client
    {
        partial void PrepareCreateVectordbUsersRevokeRoleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref string? authorization);
        partial void PrepareCreateVectordbUsersRevokeRoleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            string? authorization);
        partial void ProcessCreateVectordbUsersRevokeRoleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Revoker Role From User<br/>
        /// This operation revokes a privilege granted to the current role.<br/>
        /// &gt; Notes<br/>
        /// &gt; To complete this operation, you need to enable authentication on your Milvus instance. For details, refer to [Authenticate User Access](https://milvus.io/docs/authenticate.md).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task CreateVectordbUsersRevokeRoleAsync(
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCreateVectordbUsersRevokeRoleArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                authorization: ref authorization);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/vectordb/users/revoke_role",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            if (requestTimeout != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Request-Timeout", requestTimeout.ToString());
            }
            if (authorization != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Authorization", authorization.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateVectordbUsersRevokeRoleRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestTimeout: requestTimeout,
                authorization: authorization);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateVectordbUsersRevokeRoleResponse(
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
    }
}