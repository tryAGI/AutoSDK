//HintName: G.CloudClient.CreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPost.g.cs

#nullable enable

namespace G
{
    public partial class CloudClient
    {
        partial void PrepareCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.BodyCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPost request);
        partial void PrepareCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.BodyCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPost request);
        partial void ProcessCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Gcp Service Account
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPostResponse> CreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPostAsync(
            global::G.BodyCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPost request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/v4/cloud/provider/gcp/service-accounts", global::System.UriKind.RelativeOrAbsolute));
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (request.CredentialId != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.CredentialId}"),
                    name: "credential_id");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.ServiceAccountFile ?? global::System.Array.Empty<byte>())
                {
                    Headers =
                    {
                        ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data"),
                    },
                },
                name: "service_account_file",
                fileName: request.ServiceAccountFilename ?? string.Empty);
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPostResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPostResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Gcp Service Account
        /// </summary>
        /// <param name="credentialId"></param>
        /// <param name="serviceAccountFile"></param>
        /// <param name="serviceAccountFilename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPostResponse> CreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPostAsync(
            byte[] serviceAccountFile,
            string serviceAccountFilename,
            string? credentialId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.BodyCreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPost
            {
                CredentialId = credentialId,
                ServiceAccountFile = serviceAccountFile,
                ServiceAccountFilename = serviceAccountFilename,
            };

            return await CreateGcpServiceAccountV4CloudProviderGcpServiceAccountsPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}