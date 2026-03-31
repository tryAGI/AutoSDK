//HintName: G.IModelsClient.DeleteModel.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Delete model<br/>
        /// Delete a model
        /// </summary>
        /// <param name="model"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteModelResponse> DeleteModelAsync(
            string model,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}