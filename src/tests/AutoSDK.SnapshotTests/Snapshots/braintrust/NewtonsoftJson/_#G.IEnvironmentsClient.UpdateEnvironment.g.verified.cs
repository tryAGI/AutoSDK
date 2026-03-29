//HintName: G.IEnvironmentsClient.UpdateEnvironment.g.cs
#nullable enable

namespace G
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Partially update environment
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Environment> UpdateEnvironmentAsync(
            global::System.Guid environmentId,

            global::G.PatchEnvironment request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update environment
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="name">
        /// Name of the environment
        /// </param>
        /// <param name="slug">
        /// A url-friendly, unique identifier for the environment within an organization
        /// </param>
        /// <param name="description">
        /// Textual description of the environment
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Environment> UpdateEnvironmentAsync(
            global::System.Guid environmentId,
            string? name = default,
            string? slug = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}