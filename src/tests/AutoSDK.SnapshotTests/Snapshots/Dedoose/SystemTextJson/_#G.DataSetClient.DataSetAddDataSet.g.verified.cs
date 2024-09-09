//HintName: G.DataSetClient.DataSetAddDataSet.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class DataSetClient
    {
        partial void PrepareDataSetAddDataSetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectId,
            ref string? userId,
            ref string? title,
            ref string? description,
            ref bool areExcerptsFiltered,
            ref bool areResourcesFiltered,
            ref bool areDescriptorsFiltered,
            ref bool areTagsFiltered,
            ref bool areUsersFiltered,
            global::System.Collections.Generic.IList<string>? excerptIds,
            global::System.Collections.Generic.IList<string>? descriptorIds,
            global::System.Collections.Generic.IList<string>? userIds,
            global::System.Collections.Generic.IList<string>? resourceIds,
            global::System.Collections.Generic.IList<string>? tagIds,
            global::System.Collections.Generic.IList<string>? excludedExcerptIds);
        partial void PrepareDataSetAddDataSetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectId,
            string? userId,
            string? title,
            string? description,
            bool areExcerptsFiltered,
            bool areResourcesFiltered,
            bool areDescriptorsFiltered,
            bool areTagsFiltered,
            bool areUsersFiltered,
            global::System.Collections.Generic.IList<string>? excerptIds,
            global::System.Collections.Generic.IList<string>? descriptorIds,
            global::System.Collections.Generic.IList<string>? userIds,
            global::System.Collections.Generic.IList<string>? resourceIds,
            global::System.Collections.Generic.IList<string>? tagIds,
            global::System.Collections.Generic.IList<string>? excludedExcerptIds);
        partial void ProcessDataSetAddDataSetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDataSetAddDataSetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddDataSet.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="areExcerptsFiltered"></param>
        /// <param name="areResourcesFiltered"></param>
        /// <param name="areDescriptorsFiltered"></param>
        /// <param name="areTagsFiltered"></param>
        /// <param name="areUsersFiltered"></param>
        /// <param name="excerptIds"></param>
        /// <param name="descriptorIds"></param>
        /// <param name="userIds"></param>
        /// <param name="resourceIds"></param>
        /// <param name="tagIds"></param>
        /// <param name="excludedExcerptIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DataSetVO> DataSetAddDataSetAsync(
            string? token = default,
            string? projectId = default,
            string? userId = default,
            string? title = default,
            string? description = default,
            bool areExcerptsFiltered = default,
            bool areResourcesFiltered = default,
            bool areDescriptorsFiltered = default,
            bool areTagsFiltered = default,
            bool areUsersFiltered = default,
            global::System.Collections.Generic.IList<string>? excerptIds = default,
            global::System.Collections.Generic.IList<string>? descriptorIds = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? resourceIds = default,
            global::System.Collections.Generic.IList<string>? tagIds = default,
            global::System.Collections.Generic.IList<string>? excludedExcerptIds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDataSetAddDataSetArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                userId: ref userId,
                title: ref title,
                description: ref description,
                areExcerptsFiltered: ref areExcerptsFiltered,
                areResourcesFiltered: ref areResourcesFiltered,
                areDescriptorsFiltered: ref areDescriptorsFiltered,
                areTagsFiltered: ref areTagsFiltered,
                areUsersFiltered: ref areUsersFiltered,
                excerptIds: excerptIds,
                descriptorIds: descriptorIds,
                userIds: userIds,
                resourceIds: resourceIds,
                tagIds: tagIds,
                excludedExcerptIds: excludedExcerptIds);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/dataset/adddataset?projectId={projectId}&userId={userId}&title={title}&description={description}&areExcerptsFiltered={areExcerptsFiltered}&areResourcesFiltered={areResourcesFiltered}&areDescriptorsFiltered={areDescriptorsFiltered}&areTagsFiltered={areTagsFiltered}&areUsersFiltered={areUsersFiltered}&{string.Join("&", excerptIds?.Select(static x => $"excerptIds={x}") ?? global::System.Array.Empty<string>())}&{string.Join("&", descriptorIds?.Select(static x => $"descriptorIds={x}") ?? global::System.Array.Empty<string>())}&{string.Join("&", userIds?.Select(static x => $"userIds={x}") ?? global::System.Array.Empty<string>())}&{string.Join("&", resourceIds?.Select(static x => $"resourceIds={x}") ?? global::System.Array.Empty<string>())}&{string.Join("&", tagIds?.Select(static x => $"tagIds={x}") ?? global::System.Array.Empty<string>())}&{string.Join("&", excludedExcerptIds?.Select(static x => $"excludedExcerptIds={x}") ?? global::System.Array.Empty<string>())}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDataSetAddDataSetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                userId: userId,
                title: title,
                description: description,
                areExcerptsFiltered: areExcerptsFiltered,
                areResourcesFiltered: areResourcesFiltered,
                areDescriptorsFiltered: areDescriptorsFiltered,
                areTagsFiltered: areTagsFiltered,
                areUsersFiltered: areUsersFiltered,
                excerptIds: excerptIds,
                descriptorIds: descriptorIds,
                userIds: userIds,
                resourceIds: resourceIds,
                tagIds: tagIds,
                excludedExcerptIds: excludedExcerptIds);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDataSetAddDataSetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDataSetAddDataSetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.DataSetVO?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}