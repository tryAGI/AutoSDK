//HintName: G.IModelClient.GetModel.g.cs
#nullable enable

namespace G
{
    public partial interface IModelClient
    {
        /// <summary>
        /// List Models
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="pageNumber">
        /// Default Value: 1
        /// </param>
        /// <param name="title">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tag">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="self">
        /// Default Value: false
        /// </param>
        /// <param name="authorId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="language">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="titleLanguage">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="sortBy">
        /// Default Value: score
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetModelResponse> GetModelAsync(
            int? pageSize = default,
            int? pageNumber = default,
            string? title = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? tag = default,
            bool? self = default,
            string? authorId = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? language = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? titleLanguage = default,
            global::G.GetModelSortBy? sortBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}