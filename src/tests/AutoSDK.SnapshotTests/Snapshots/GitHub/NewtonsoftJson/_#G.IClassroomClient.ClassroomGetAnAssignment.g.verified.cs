//HintName: G.IClassroomClient.ClassroomGetAnAssignment.g.cs
#nullable enable

namespace G
{
    public partial interface IClassroomClient
    {
        /// <summary>
        /// Get an assignment<br/>
        /// Gets a GitHub Classroom assignment. Assignment will only be returned if the current user is an administrator of the GitHub Classroom for the assignment.
        /// </summary>
        /// <param name="assignmentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClassroomAssignment> ClassroomGetAnAssignmentAsync(
            int assignmentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}