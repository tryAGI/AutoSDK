//HintName: G.IModelPriceMapClient.UpdateModelPrice.g.cs
#nullable enable

namespace G
{
    public partial interface IModelPriceMapClient
    {
        /// <summary>
        /// Update Model Price
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateModelPriceAsync(
            global::System.Guid id,
            global::G.ModelPriceMapUpdateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Model Price
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="startTime"></param>
        /// <param name="matchPath">
        /// Default Value: [model, model_name, model_id, model_path, endpoint_name]
        /// </param>
        /// <param name="matchPattern"></param>
        /// <param name="promptCost"></param>
        /// <param name="completionCost"></param>
        /// <param name="provider"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateModelPriceAsync(
            global::System.Guid id,
            string name,
            string matchPattern,
            global::G.AnyOf<double?, string> promptCost,
            global::G.AnyOf<double?, string> completionCost,
            global::System.DateTime? startTime = default,
            global::System.Collections.Generic.IList<string>? matchPath = default,
            string? provider = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}