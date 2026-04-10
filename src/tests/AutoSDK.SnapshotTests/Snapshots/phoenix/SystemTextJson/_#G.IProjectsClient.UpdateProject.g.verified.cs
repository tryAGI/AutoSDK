//HintName: G.IProjectsClient.UpdateProject.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update a project by ID or name<br/>
        /// Update an existing project with new configuration. Project names cannot be changed. The project identifier is either project ID or project name. Note: When using a project name as the identifier, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name. If using a project name, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateProjectResponseBody> UpdateProjectAsync(
            string projectIdentifier,

            global::G.UpdateProjectRequestBody request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a project by ID or name<br/>
        /// Update an existing project with new configuration. Project names cannot be changed. The project identifier is either project ID or project name. Note: When using a project name as the identifier, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name. If using a project name, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateProjectResponseBody> UpdateProjectAsync(
            string projectIdentifier,
            string? description = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}