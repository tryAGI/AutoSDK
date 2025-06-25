﻿//HintName: G.IClassroomClient.ClassroomListClassrooms.g.cs
#nullable enable

namespace G
{
    public partial interface IClassroomClient
    {
        /// <summary>
        /// List classrooms<br/>
        /// Lists GitHub Classroom classrooms for the current user. Classrooms will only be returned if the current user is an administrator of one or more GitHub Classrooms.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SimpleClassroom>> ClassroomListClassroomsAsync(
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}