//HintName: G.AppsClient.AppsListAccountsForPlanStubbed.g.cs

#nullable enable

namespace G
{
    public partial class AppsClient
    {
        partial void PrepareAppsListAccountsForPlanStubbedArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int planId,
            ref global::G.AppsListAccountsForPlanStubbedSort? sort,
            ref global::G.AppsListAccountsForPlanStubbedDirection? direction,
            ref int perPage,
            ref int page);
        partial void PrepareAppsListAccountsForPlanStubbedRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int planId,
            global::G.AppsListAccountsForPlanStubbedSort? sort,
            global::G.AppsListAccountsForPlanStubbedDirection? direction,
            int perPage,
            int page);
        partial void ProcessAppsListAccountsForPlanStubbedResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAppsListAccountsForPlanStubbedResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List accounts for a plan (stubbed)<br/>
        /// Returns repository and organization accounts associated with the specified plan, including free plans. For per-seat pricing, you see the list of accounts that have purchased the plan, including the number of seats purchased. When someone submits a plan change that won't be processed until the end of their billing cycle, you will also see the upcoming pending change.<br/>
        /// GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.
        /// </summary>
        /// <param name="planId"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MarketplacePurchase>> AppsListAccountsForPlanStubbedAsync(
            int planId,
            global::G.AppsListAccountsForPlanStubbedSort? sort,
            global::G.AppsListAccountsForPlanStubbedDirection? direction,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareAppsListAccountsForPlanStubbedArguments(
                httpClient: _httpClient,
                planId: ref planId,
                sort: ref sort,
                direction: ref direction,
                perPage: ref perPage,
                page: ref page);

            var sortValue = sort switch
            {
                global::G.AppsListAccountsForPlanStubbedSort.Created => "created",
                global::G.AppsListAccountsForPlanStubbedSort.Updated => "updated",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                global::G.AppsListAccountsForPlanStubbedDirection.Asc => "asc",
                global::G.AppsListAccountsForPlanStubbedDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/marketplace_listing/stubbed/plans/{planId}/accounts?sort={sortValue}&direction={directionValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAppsListAccountsForPlanStubbedRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                planId: planId,
                sort: sort,
                direction: direction,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAppsListAccountsForPlanStubbedResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAppsListAccountsForPlanStubbedResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.MarketplacePurchase>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}