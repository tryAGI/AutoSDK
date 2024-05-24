//HintName: G.DescriptorClient.DescriptorDeleteDescriptor.g.cs

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        /// <summary>
        /// DeleteDescriptor.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="projectIDL"></param>
        /// <param name="createStamp"></param>
        /// <param name="createByIDL"></param>
        /// <param name="descriptorSetIDL"></param>
        /// <param name="valuesData"></param>
        /// <param name="dynamicValuesData"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Descriptor> DescriptorDeleteDescriptorAsync(
            string token,
            string projectIdKey,
            string projectId,
            string id,
            string projectIDL,
            global::System.DateTime createStamp,
            string createByIDL,
            string descriptorSetIDL,
            byte valuesData,
            byte dynamicValuesData,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/descriptor/deletedescriptor?ProjectIdKey={projectIdKey}&ProjectId={projectId}&Id={id}&ProjectIDL={projectIDL}&CreateStamp={createStamp}&CreateByIDL={createByIDL}&DescriptorSetIDL={descriptorSetIDL}&ValuesData={valuesData}&DynamicValuesData={dynamicValuesData}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<Descriptor>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}