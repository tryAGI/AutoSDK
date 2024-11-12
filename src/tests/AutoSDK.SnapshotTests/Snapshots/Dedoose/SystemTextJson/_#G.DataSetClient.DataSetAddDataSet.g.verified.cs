//HintName: G.DataSetClient.DataSetAddDataSet.g.cs

#nullable enable

namespace G
{
    public partial class DataSetClient
    {
        partial void PrepareDataSetAddDataSetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? projectId,
            ref global::System.Guid? userId,
            ref string? title,
            ref string? description,
            ref bool? areExcerptsFiltered,
            ref bool? areResourcesFiltered,
            ref bool? areDescriptorsFiltered,
            ref bool? areTagsFiltered,
            ref bool? areUsersFiltered,
            global::System.Collections.Generic.IList<global::System.Guid>? excerptIds,
            global::System.Collections.Generic.IList<global::System.Guid>? descriptorIds,
            global::System.Collections.Generic.IList<global::System.Guid>? userIds,
            global::System.Collections.Generic.IList<global::System.Guid>? resourceIds,
            global::System.Collections.Generic.IList<global::System.Guid>? tagIds,
            global::System.Collections.Generic.IList<global::System.Guid>? excludedExcerptIds);
        partial void PrepareDataSetAddDataSetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? projectId,
            global::System.Guid? userId,
            string? title,
            string? description,
            bool? areExcerptsFiltered,
            bool? areResourcesFiltered,
            bool? areDescriptorsFiltered,
            bool? areTagsFiltered,
            bool? areUsersFiltered,
            global::System.Collections.Generic.IList<global::System.Guid>? excerptIds,
            global::System.Collections.Generic.IList<global::System.Guid>? descriptorIds,
            global::System.Collections.Generic.IList<global::System.Guid>? userIds,
            global::System.Collections.Generic.IList<global::System.Guid>? resourceIds,
            global::System.Collections.Generic.IList<global::System.Guid>? tagIds,
            global::System.Collections.Generic.IList<global::System.Guid>? excludedExcerptIds);
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
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DataSetVO> DataSetAddDataSetAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? userId = default,
            string? title = default,
            string? description = default,
            bool? areExcerptsFiltered = default,
            bool? areResourcesFiltered = default,
            bool? areDescriptorsFiltered = default,
            bool? areTagsFiltered = default,
            bool? areUsersFiltered = default,
            global::System.Collections.Generic.IList<global::System.Guid>? excerptIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? descriptorIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? userIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? resourceIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? excludedExcerptIds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareDataSetAddDataSetArguments(
                httpClient: HttpClient,
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

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/dataset/adddataset",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("userId", userId?.ToString()) 
                .AddOptionalParameter("title", title) 
                .AddOptionalParameter("description", description) 
                .AddOptionalParameter("areExcerptsFiltered", areExcerptsFiltered?.ToString()) 
                .AddOptionalParameter("areResourcesFiltered", areResourcesFiltered?.ToString()) 
                .AddOptionalParameter("areDescriptorsFiltered", areDescriptorsFiltered?.ToString()) 
                .AddOptionalParameter("areTagsFiltered", areTagsFiltered?.ToString()) 
                .AddOptionalParameter("areUsersFiltered", areUsersFiltered?.ToString()) 
                .AddOptionalParameter("excerptIds", excerptIds, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("descriptorIds", descriptorIds, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("userIds", userIds, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("resourceIds", resourceIds, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("tagIds", tagIds, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("excludedExcerptIds", excludedExcerptIds, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDataSetAddDataSetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
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

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDataSetAddDataSetResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Token is null.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                string? __value_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_400, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = await global::System.Text.Json.JsonSerializer.DeserializeAsync<string?>(__contentStream_400, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<string>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Token is invalid.
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                string? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content_401, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = await global::System.Text.Json.JsonSerializer.DeserializeAsync<string?>(__contentStream_401, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<string>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessDataSetAddDataSetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::G.DataSetVO.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
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

                using var __responseStream = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                var __responseValue = await global::G.DataSetVO.FromJsonStreamAsync(__responseStream, JsonSerializerOptions).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}