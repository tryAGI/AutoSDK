//HintName: G.IPromptTemplatesClient.GetAllPromptTemplatesGet.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptTemplatesClient
    {
        /// <summary>
        /// Get All
        /// </summary>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="label"></param>
        /// <param name="name"></param>
        /// <param name="tags"></param>
        /// <param name="status">
        /// Default Value: active
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListPromptTemplates> GetAllPromptTemplatesGetAsync(
            int? page = default,
            int? perPage = default,
            string? label = default,
            string? name = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? tags = default,
            global::G.GetAllPromptTemplatesGetStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}