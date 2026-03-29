//HintName: G.IApi.NotebookStartNotebookStartGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Jupyter Lab Server Start<br/>
        /// Starts a jupyter lab server for running development code
        /// </summary>
        /// <param name="browserless">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> NotebookStartNotebookStartGetAsync(
            bool? browserless = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}