//HintName: G.IApi.ModelSchemaModelsModelNameSchemaVariantKeyGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Model Schema
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="variantKey"></param>
        /// <param name="version"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SchemaOut> ModelSchemaModelsModelNameSchemaVariantKeyGetAsync(
            string modelName,
            global::G.SchemaVariantKey variantKey,
            string? version = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}