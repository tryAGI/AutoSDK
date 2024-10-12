//HintName: G.IDatasetsClient.Generate.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Generate<br/>
        /// Generate synthetic examples for a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GenerateAsync(
            global::System.Guid datasetId,
            global::G.GenerateSyntheticExamplesBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate<br/>
        /// Generate synthetic examples for a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="exampleIds"></param>
        /// <param name="numExamples"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GenerateAsync(
            global::System.Guid datasetId,
            int numExamples,
            global::System.Collections.Generic.IList<global::System.Guid>? exampleIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}