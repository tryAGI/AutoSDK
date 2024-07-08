//HintName: G.ExcerptClient.ExcerptStartDeleteExcerptsJob.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ExcerptClient
    {
        partial void PrepareExcerptStartDeleteExcerptsJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string currentProjectId,
            global::System.Collections.Generic.IList<string> excerptIds);
        partial void PrepareExcerptStartDeleteExcerptsJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string currentProjectId,
            global::System.Collections.Generic.IList<string> excerptIds);
        partial void ProcessExcerptStartDeleteExcerptsJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessExcerptStartDeleteExcerptsJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// StartDeleteExcerptsJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="currentProjectId"></param>
        /// <param name="excerptIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> ExcerptStartDeleteExcerptsJobAsync(
            string token,
            string currentProjectId,
            global::System.Collections.Generic.IList<string> excerptIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareExcerptStartDeleteExcerptsJobArguments(
                httpClient: _httpClient,
                token: ref token,
                currentProjectId: ref currentProjectId,
                excerptIds: excerptIds);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/excerpt/startdeleteexcerptsjob?currentProjectId={currentProjectId}&{string.Join("&", excerptIds.Select(static x => $"excerptIds={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareExcerptStartDeleteExcerptsJobRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                currentProjectId: currentProjectId,
                excerptIds: excerptIds);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessExcerptStartDeleteExcerptsJobResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessExcerptStartDeleteExcerptsJobResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}