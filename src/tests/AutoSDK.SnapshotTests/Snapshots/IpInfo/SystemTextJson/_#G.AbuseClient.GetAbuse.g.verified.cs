//HintName: G.AbuseClient.GetAbuse.g.cs

#nullable enable

namespace G
{
    public partial class AbuseClient
    {
        partial void PrepareGetAbuseArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string ip);
        partial void PrepareGetAbuseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string ip);
        partial void ProcessGetAbuseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAbuseResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Our abuse contact API returns data containing information belonging to the abuse contact of every IP address on the Internet. Fields included in this response are the abuse contact's email address, postal/ZIP code, city, state, country, name, network, and phone number.<br/>
        /// Our abuse contact API returns data containing information belonging to the abuse contact of every IP address on the Internet. Fields included in this response are the abuse contact's email address, postal/ZIP code, city, state, country, name, network, and phone number.
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AbuseResponse> GetAbuseAsync(
            string ip,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetAbuseArguments(
                httpClient: _httpClient,
                ip: ref ip);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/{ip}/abuse", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetAbuseRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                ip: ip);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetAbuseResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetAbuseResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.AbuseResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}