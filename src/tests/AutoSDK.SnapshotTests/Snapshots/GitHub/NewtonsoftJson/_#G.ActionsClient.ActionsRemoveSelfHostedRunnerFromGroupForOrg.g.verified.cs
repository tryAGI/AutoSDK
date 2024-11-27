//HintName: G.ActionsClient.ActionsRemoveSelfHostedRunnerFromGroupForOrg.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsRemoveSelfHostedRunnerFromGroupForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int runnerGroupId,
            ref int runnerId);
        partial void PrepareActionsRemoveSelfHostedRunnerFromGroupForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int runnerGroupId,
            int runnerId);
        partial void ProcessActionsRemoveSelfHostedRunnerFromGroupForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Remove a self-hosted runner from a group for an organization<br/>
        /// Removes a self-hosted runner from a group configured in an organization. The runner is then returned to the default group.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="runnerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ActionsRemoveSelfHostedRunnerFromGroupForOrgAsync(
            string org,
            int runnerGroupId,
            int runnerId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareActionsRemoveSelfHostedRunnerFromGroupForOrgArguments(
                httpClient: HttpClient,
                org: ref org,
                runnerGroupId: ref runnerGroupId,
                runnerId: ref runnerId);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/actions/runner-groups/{runnerGroupId}/runners/{runnerId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareActionsRemoveSelfHostedRunnerFromGroupForOrgRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                runnerGroupId: runnerGroupId,
                runnerId: runnerId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessActionsRemoveSelfHostedRunnerFromGroupForOrgResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
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
}