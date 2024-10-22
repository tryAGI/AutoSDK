//HintName: G.OrgsClient.GetDashboard.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareGetDashboardArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.OrganizationDashboardType type,
            ref global::G.OrganizationDashboardColorScheme colorScheme);
        partial void PrepareGetDashboardRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.OrganizationDashboardType type,
            global::G.OrganizationDashboardColorScheme colorScheme);
        partial void ProcessGetDashboardResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDashboardResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Dashboard
        /// </summary>
        /// <param name="type">
        /// Enum for acceptable types of dashboards.
        /// </param>
        /// <param name="colorScheme">
        /// Enum for acceptable color schemes of dashboards.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OrganizationDashboardSchema> GetDashboardAsync(
            global::G.OrganizationDashboardType type,
            global::G.OrganizationDashboardColorScheme colorScheme,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetDashboardArguments(
                httpClient: HttpClient,
                type: ref type,
                colorScheme: ref colorScheme);

            var typeValue = type switch
            {
                global::G.OrganizationDashboardType.Invoices => "invoices",
                global::G.OrganizationDashboardType.Usage => "usage",
                global::G.OrganizationDashboardType.Credits => "credits",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var colorSchemeValue = colorScheme switch
            {
                global::G.OrganizationDashboardColorScheme.Light => "light",
                global::G.OrganizationDashboardColorScheme.Dark => "dark",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: "/api/v1/orgs/current/dashboard",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("type", typeValue.ToString()) 
                .AddRequiredParameter("color_scheme", colorSchemeValue.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

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
            PrepareGetDashboardRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                type: type,
                colorScheme: colorScheme);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetDashboardResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessGetDashboardResponseContent(
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
                global::G.OrganizationDashboardSchema.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}