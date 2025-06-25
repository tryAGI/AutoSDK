//HintName: G.IApi.ModelPublicityModelsModelNamePublicityPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Model Publicity
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ModelPublicityModelsModelNamePublicityPostAsync(
            string modelName,
            global::G.ModelPublicityIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Model Publicity
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="public">
        /// whether to make the model public of private
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ModelPublicityModelsModelNamePublicityPostAsync(
            string modelName,
            bool @public,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}