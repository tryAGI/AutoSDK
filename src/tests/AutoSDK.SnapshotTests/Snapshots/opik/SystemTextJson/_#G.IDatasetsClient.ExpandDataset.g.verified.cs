//HintName: G.IDatasetsClient.ExpandDataset.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Expand dataset with synthetic samples<br/>
        /// Generate synthetic dataset samples using LLM based on existing data patterns
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetExpansionResponse> ExpandDatasetAsync(
            global::System.Guid id,

            global::G.DatasetExpansionWrite request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Expand dataset with synthetic samples<br/>
        /// Generate synthetic dataset samples using LLM based on existing data patterns
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model">
        /// The model to use for synthetic data generation<br/>
        /// Example: gpt-4
        /// </param>
        /// <param name="sampleCount">
        /// Number of synthetic samples to generate<br/>
        /// Example: 10
        /// </param>
        /// <param name="preserveFields">
        /// Fields to preserve patterns from original data<br/>
        /// Example: [input, expected_output]
        /// </param>
        /// <param name="variationInstructions">
        /// Additional instructions for data variation<br/>
        /// Example: Create variations that test edge cases
        /// </param>
        /// <param name="customPrompt">
        /// Custom prompt to use for generation instead of auto-generated one
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetExpansionResponse> ExpandDatasetAsync(
            global::System.Guid id,
            string model,
            int? sampleCount = default,
            global::System.Collections.Generic.IList<string>? preserveFields = default,
            string? variationInstructions = default,
            string? customPrompt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}