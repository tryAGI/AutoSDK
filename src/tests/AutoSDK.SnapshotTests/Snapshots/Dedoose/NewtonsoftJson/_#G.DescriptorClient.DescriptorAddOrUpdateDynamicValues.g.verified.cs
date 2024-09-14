//HintName: G.DescriptorClient.DescriptorAddOrUpdateDynamicValues.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        partial void PrepareDescriptorAddOrUpdateDynamicValuesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid projectId,
            ref global::System.Guid resourceId,
            ref global::System.Guid setId,
            ref global::System.Guid descriptorId,
            global::System.Collections.Generic.IList<global::G.DynamicDescriptorValueDTO>? values);
        partial void PrepareDescriptorAddOrUpdateDynamicValuesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid projectId,
            global::System.Guid resourceId,
            global::System.Guid setId,
            global::System.Guid descriptorId,
            global::System.Collections.Generic.IList<global::G.DynamicDescriptorValueDTO>? values);
        partial void ProcessDescriptorAddOrUpdateDynamicValuesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDescriptorAddOrUpdateDynamicValuesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddOrUpdateDynamicValues.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="setId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="values"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DescriptorAddOrUpdateDynamicValuesResponse> DescriptorAddOrUpdateDynamicValuesAsync(
            string? token = default,
            global::System.Guid projectId = default,
            global::System.Guid resourceId = default,
            global::System.Guid setId = default,
            global::System.Guid descriptorId = default,
            global::System.Collections.Generic.IList<global::G.DynamicDescriptorValueDTO>? values = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDescriptorAddOrUpdateDynamicValuesArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                resourceId: ref resourceId,
                setId: ref setId,
                descriptorId: ref descriptorId,
                values: values);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/descriptor/addorupdatedynamicvalues?projectId={projectId}&resourceId={resourceId}&setId={setId}&descriptorId={descriptorId}&{string.Join("&", values?.Select(static x => $"values={x}") ?? global::System.Array.Empty<string>())}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDescriptorAddOrUpdateDynamicValuesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                resourceId: resourceId,
                setId: setId,
                descriptorId: descriptorId,
                values: values);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDescriptorAddOrUpdateDynamicValuesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDescriptorAddOrUpdateDynamicValuesResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DescriptorAddOrUpdateDynamicValuesResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}