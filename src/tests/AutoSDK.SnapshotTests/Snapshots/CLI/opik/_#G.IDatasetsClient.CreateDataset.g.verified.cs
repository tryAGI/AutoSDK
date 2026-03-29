//HintName: G.IDatasetsClient.CreateDataset.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create dataset<br/>
        /// Create dataset
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateDatasetAsync(

            global::G.DatasetWrite request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create dataset<br/>
        /// Create dataset
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="projectId">
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </param>
        /// <param name="projectName">
        /// For project scope, specify either project_id or project_name. If project_name is provided and the project does not exist, it will be created. Ignored when project_id is provided. If neither is provided, the dataset is created at workspace level.
        /// </param>
        /// <param name="type"></param>
        /// <param name="visibility"></param>
        /// <param name="tags"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateDatasetAsync(
            string name,
            global::System.Guid? id = default,
            global::System.Guid? projectId = default,
            string? projectName = default,
            global::G.DatasetWriteType? type = default,
            global::G.DatasetWriteVisibility? visibility = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}