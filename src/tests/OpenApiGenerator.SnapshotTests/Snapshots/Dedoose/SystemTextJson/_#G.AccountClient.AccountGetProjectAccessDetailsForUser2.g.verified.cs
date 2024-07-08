//HintName: G.AccountClient.AccountGetProjectAccessDetailsForUser2.g.cs

#nullable enable

namespace G
{
    public partial class AccountClient
    {
        partial void PrepareAccountGetProjectAccessDetailsForUser2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string userId);
        partial void PrepareAccountGetProjectAccessDetailsForUser2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string userId);
        partial void ProcessAccountGetProjectAccessDetailsForUser2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAccountGetProjectAccessDetailsForUser2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// GetProjectAccessDetailsForUser.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ProjectAccessDetails>> AccountGetProjectAccessDetailsForUser2Async(
            string token,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareAccountGetProjectAccessDetailsForUser2Arguments(
                httpClient: _httpClient,
                token: ref token,
                userId: ref userId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/account/getprojectaccessdetailsforuser2?userId={userId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAccountGetProjectAccessDetailsForUser2Request(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                userId: userId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAccountGetProjectAccessDetailsForUser2Response(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAccountGetProjectAccessDetailsForUser2ResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.ProjectAccessDetails>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}