//HintName: G.IModelsClient.ListModelsV1ModelsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List Models<br/>
        /// List all models available to the user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelList> ListModelsV1ModelsGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}