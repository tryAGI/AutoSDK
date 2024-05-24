//HintName: G.OidcClient.OidcUpdateOidcCustomSubTemplateForOrg.g.cs

#nullable enable

namespace G
{
    public partial class OidcClient
    {
        /// <summary>
        /// Set the customization template for an OIDC subject claim for an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<EmptyObject> OidcUpdateOidcCustomSubTemplateForOrgAsync(
            string org,
            OidcCustomSub request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/actions/oidc/customization/sub", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<EmptyObject>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Set the customization template for an OIDC subject claim for an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="includeClaimKeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<EmptyObject> OidcUpdateOidcCustomSubTemplateForOrgAsync(
            string org,
            global::System.Collections.Generic.IList<string> includeClaimKeys,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new OidcCustomSub
            {
                IncludeClaimKeys = includeClaimKeys,
            };

            return await OidcUpdateOidcCustomSubTemplateForOrgAsync(
                org: org,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}