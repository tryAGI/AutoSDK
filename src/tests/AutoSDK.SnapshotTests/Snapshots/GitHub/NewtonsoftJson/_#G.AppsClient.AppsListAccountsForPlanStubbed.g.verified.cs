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
            ref int? perPage,
            ref int? page);
        partial void PrepareAppsListAccountsForPlanStubbedRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int planId,
            global::G.AppsListAccountsForPlanStubbedSort? sort,
            global::G.AppsListAccountsForPlanStubbedDirection? direction,
            int? perPage,
            int? page);
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
        /// GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth apps must use [basic authentication](https://docs.github.com/rest/authentication/authenticating-to-the-rest-api#using-basic-authentication) with their client ID and client secret to access this endpoint.
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
            global::G.AppsListAccountsForPlanStubbedSort? sort = global::G.AppsListAccountsForPlanStubbedSort.Created,
            global::G.AppsListAccountsForPlanStubbedDirection? direction = default,
            int? perPage = 30,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAppsListAccountsForPlanStubbedArguments(
                httpClient: HttpClient,
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
            var __pathBuilder = new PathBuilder(
                path: $"/marketplace_listing/stubbed/plans/{planId}/accounts",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("sort", sortValue?.ToString()) 
                .AddOptionalParameter("direction", directionValue?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAppsListAccountsForPlanStubbedRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                planId: planId,
                sort: sort,
                direction: direction,
                perPage: perPage,
                page: page);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAppsListAccountsForPlanStubbedResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessAppsListAccountsForPlanStubbedResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.MarketplacePurchase>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}