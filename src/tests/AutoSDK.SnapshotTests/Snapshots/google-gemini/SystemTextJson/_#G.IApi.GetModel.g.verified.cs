//HintName: G.IApi.GetModel.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets information about a specific Model.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Model> GetModelAsync(
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}