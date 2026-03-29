//HintName: G.IApi.ModelRemoveModelRemovePost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Remove a model<br/>
        /// Remove the model with the given model ID
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelsDescriptions> ModelRemoveModelRemovePostAsync(

            global::G.ClearModelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a model<br/>
        /// Remove the model with the given model ID
        /// </summary>
        /// <param name="modelId">
        /// A unique model identifier<br/>
        /// Example: raccoon-detector-1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelsDescriptions> ModelRemoveModelRemovePostAsync(
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}