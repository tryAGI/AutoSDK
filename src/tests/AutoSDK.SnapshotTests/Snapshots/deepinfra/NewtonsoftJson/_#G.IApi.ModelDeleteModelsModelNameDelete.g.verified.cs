//HintName: G.IApi.ModelDeleteModelsModelNameDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Model Delete
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="version">
        /// delete a particular version, pass 'ALL' to wipe everything
        /// </param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ModelDeleteModelsModelNameDeleteAsync(
            string modelName,
            string version,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}