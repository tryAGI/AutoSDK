//HintName: G.CopilotClient.CopilotListCopilotSeatsForEnterprise.g.cs

#nullable enable

namespace G
{
    public partial class CopilotClient
    {
        partial void PrepareCopilotListCopilotSeatsForEnterpriseArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string enterprise,
            ref int? page,
            ref int? perPage);
        partial void PrepareCopilotListCopilotSeatsForEnterpriseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string enterprise,
            int? page,
            int? perPage);
        partial void ProcessCopilotListCopilotSeatsForEnterpriseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCopilotListCopilotSeatsForEnterpriseResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List all Copilot seat assignments for an enterprise<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in beta and is subject to change.<br/>
        /// Lists all active Copilot seats across organizations or enterprise teams for an enterprise with a Copilot Business or Copilot Enterprise subscription.<br/>
        /// Users with access through multiple organizations or enterprise teams will only be counted toward `total_seats` once.<br/>
        /// For each organization or enterprise team which grants Copilot access to a user, a seat detail object will appear in the `seats` array.<br/>
        /// Only enterprise owners and billing managers can view assigned Copilot seats across their child organizations or enterprise teams.<br/>
        /// Personal access tokens (classic) need either the `manage_billing:copilot` or `read:enterprise` scopes to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 50
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CopilotListCopilotSeatsForEnterpriseResponse> CopilotListCopilotSeatsForEnterpriseAsync(
            string enterprise,
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCopilotListCopilotSeatsForEnterpriseArguments(
                httpClient: HttpClient,
                enterprise: ref enterprise,
                page: ref page,
                perPage: ref perPage);

            var __pathBuilder = new PathBuilder(
                path: $"/enterprises/{enterprise}/copilot/billing/seats",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCopilotListCopilotSeatsForEnterpriseRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                enterprise: enterprise,
                page: page,
                perPage: perPage);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCopilotListCopilotSeatsForEnterpriseResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCopilotListCopilotSeatsForEnterpriseResponseContent(
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
                global::G.CopilotListCopilotSeatsForEnterpriseResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}