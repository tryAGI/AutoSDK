//HintName: G.IApi.ModelMetaUpdateModelsModelNameMetaPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Model Meta Update
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ModelMetaUpdateModelsModelNameMetaPostAsync(
            string modelName,
            global::G.ModelMetaIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Model Meta Update
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="description">
        /// short model description in plain text
        /// </param>
        /// <param name="githubUrl">
        /// source code project link (empty to delete)
        /// </param>
        /// <param name="paperUrl">
        /// paper/research link (empty to delete)
        /// </param>
        /// <param name="licenseUrl">
        /// usage license link (empty to delete)
        /// </param>
        /// <param name="readme">
        /// markdown flavored model readme
        /// </param>
        /// <param name="coverImgUrl">
        /// dataurl or regular url to cover image (empty to delete)
        /// </param>
        /// <param name="reportedType">
        /// model type
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ModelMetaUpdateModelsModelNameMetaPostAsync(
            string modelName,
            string? xiApiKey = default,
            string? description = default,
            string? githubUrl = default,
            string? paperUrl = default,
            string? licenseUrl = default,
            string? readme = default,
            string? coverImgUrl = default,
            global::G.HFTasksE? reportedType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}