//HintName: G.IClassroomClient.ClassroomGetAClassroom.g.cs
#nullable enable

namespace G
{
    public partial interface IClassroomClient
    {
        /// <summary>
        /// Get a classroom<br/>
        /// Gets a GitHub Classroom classroom for the current user. Classroom will only be returned if the current user is an administrator of the GitHub Classroom.
        /// </summary>
        /// <param name="classroomId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Classroom> ClassroomGetAClassroomAsync(
            int classroomId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}