//HintName: G.ClassroomClient.ClassroomListAssignmentsForAClassroom.g.cs

#nullable enable

namespace G
{
    public partial class ClassroomClient
    {
        partial void PrepareClassroomListAssignmentsForAClassroomArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int classroomId,
            ref int page,
            ref int perPage);
        partial void PrepareClassroomListAssignmentsForAClassroomRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int classroomId,
            int page,
            int perPage);
        partial void ProcessClassroomListAssignmentsForAClassroomResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessClassroomListAssignmentsForAClassroomResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List assignments for a classroom<br/>
        /// Lists GitHub Classroom assignments for a classroom. Assignments will only be returned if the current user is an administrator of the GitHub Classroom.
        /// </summary>
        /// <param name="classroomId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SimpleClassroomAssignment>> ClassroomListAssignmentsForAClassroomAsync(
            int classroomId,
            int page = 1,
            int perPage = 30,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareClassroomListAssignmentsForAClassroomArguments(
                httpClient: _httpClient,
                classroomId: ref classroomId,
                page: ref page,
                perPage: ref perPage);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/classrooms/{classroomId}/assignments?page={page}&per_page={perPage}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareClassroomListAssignmentsForAClassroomRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                classroomId: classroomId,
                page: page,
                perPage: perPage);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessClassroomListAssignmentsForAClassroomResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessClassroomListAssignmentsForAClassroomResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.SimpleClassroomAssignment>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}