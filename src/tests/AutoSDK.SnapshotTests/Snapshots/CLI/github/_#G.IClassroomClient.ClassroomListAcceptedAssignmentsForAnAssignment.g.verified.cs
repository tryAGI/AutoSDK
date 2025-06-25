//HintName: G.IClassroomClient.ClassroomListAcceptedAssignmentsForAnAssignment.g.cs
#nullable enable

namespace G
{
    public partial interface IClassroomClient
    {
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
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ClassroomAcceptedAssignment>> ClassroomListAcceptedAssignmentsForAnAssignmentAsync(
            int assignmentId,
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}