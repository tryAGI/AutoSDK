//HintName: G.IStepsClient.RetrieveStep.g.cs
#nullable enable

namespace G
{
    public partial interface IStepsClient
    {
        /// <summary>
        /// Retrieve Step<br/>
        /// Get a step by ID.
        /// </summary>
        /// <param name="stepId">
        /// The ID of the step in the format 'step-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Step> RetrieveStepAsync(
            string stepId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}