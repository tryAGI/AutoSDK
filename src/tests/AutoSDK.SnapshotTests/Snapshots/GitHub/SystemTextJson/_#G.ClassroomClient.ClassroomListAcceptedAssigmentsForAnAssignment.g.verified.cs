//HintName: G.ClassroomClient.ClassroomListAcceptedAssigmentsForAnAssignment.g.cs

#nullable enable

namespace G
{
    public partial class ClassroomClient
    {
        partial void PrepareClassroomListAcceptedAssigmentsForAnAssignmentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int assignmentId,
            ref int page,
            ref int perPage);
        partial void PrepareClassroomListAcceptedAssigmentsForAnAssignmentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int assignmentId,
            int page,
            int perPage);
        partial void ProcessClassroomListAcceptedAssigmentsForAnAssignmentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessClassroomListAcceptedAssigmentsForAnAssignmentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List accepted assignments for an assignment<br/>
        /// Lists any assignment repositories that have been created by students accepting a GitHub Classroom assignment. Accepted assignments will only be returned if the current user is an administrator of the GitHub Classroom for the assignment.
        /// </summary>
        /// <param name="assignmentId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ClassroomAcceptedAssignment>> ClassroomListAcceptedAssigmentsForAnAssignmentAsync(
            int assignmentId,
            int page = 1,
            int perPage = 30,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareClassroomListAcceptedAssigmentsForAnAssignmentArguments(
                httpClient: _httpClient,
                assignmentId: ref assignmentId,
                page: ref page,
                perPage: ref perPage);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/assignments/{assignmentId}/accepted_assignments?page={page}&per_page={perPage}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareClassroomListAcceptedAssigmentsForAnAssignmentRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                assignmentId: assignmentId,
                page: page,
                perPage: perPage);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessClassroomListAcceptedAssigmentsForAnAssignmentResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessClassroomListAcceptedAssigmentsForAnAssignmentResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.ClassroomAcceptedAssignment>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}