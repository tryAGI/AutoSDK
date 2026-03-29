//HintName: G.IBlueprints2Client.Create.g.cs
#nullable enable

namespace G
{
    public partial interface IBlueprints2Client
    {
        /// <summary>
        /// Create blueprint<br/>
        /// Create a new blueprint
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Blueprint> CreateAsync(

            global::G.BlueprintRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create blueprint<br/>
        /// Create a new blueprint
        /// </summary>
        /// <param name="createdBy"></param>
        /// <param name="description">
        /// Project description
        /// </param>
        /// <param name="labelConfig">
        /// Labeling configuration in XML format
        /// </param>
        /// <param name="project"></param>
        /// <param name="taskIds">
        /// Included only in requests
        /// </param>
        /// <param name="title">
        /// Blueprint name. Must be between 3 and 50 characters long.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Blueprint> CreateAsync(
            int project,
            global::System.Collections.Generic.IList<int> taskIds,
            int? createdBy = default,
            string? description = default,
            string? labelConfig = default,
            string? title = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}