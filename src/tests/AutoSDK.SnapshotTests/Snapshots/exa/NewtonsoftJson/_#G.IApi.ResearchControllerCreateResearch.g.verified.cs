//HintName: G.IApi.ResearchControllerCreateResearch.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create a new research request
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResearchDtoClass> ResearchControllerCreateResearchAsync(

            global::G.ResearchCreateRequestDtoClass request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new research request
        /// </summary>
        /// <param name="model">
        /// Default Value: exa-research
        /// </param>
        /// <param name="instructions">
        /// Instructions for what research should be conducted
        /// </param>
        /// <param name="outputSchema"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResearchDtoClass> ResearchControllerCreateResearchAsync(
            string instructions,
            global::G.ResearchCreateRequestDtoClassModel? model = default,
            object? outputSchema = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}