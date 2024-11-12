//HintName: G.SchemaClient.TenantExists.g.cs

#nullable enable

namespace G
{
    public partial class SchemaClient
    {
        partial void PrepareTenantExistsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string className,
            ref string tenantName,
            ref bool? consistency);
        partial void PrepareTenantExistsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string className,
            string tenantName,
            bool? consistency);
        partial void ProcessTenantExistsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Check whether a tenant exists<br/>
        /// Check if a tenant exists for a specific class
        /// </summary>
        /// <param name="className"></param>
        /// <param name="tenantName"></param>
        /// <param name="consistency">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task TenantExistsAsync(
            string className,
            string tenantName,
            bool? consistency = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareTenantExistsArguments(
                httpClient: HttpClient,
                className: ref className,
                tenantName: ref tenantName,
                consistency: ref consistency);

            var __pathBuilder = new PathBuilder(
                path: $"/schema/{className}/tenants/{tenantName}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Head,
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

            if (consistency != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("consistency", consistency.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTenantExistsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                className: className,
                tenantName: tenantName,
                consistency: consistency);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTenantExistsResponse(
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