//HintName: G.IExamplesClient.ValidateExamples.g.cs
#nullable enable

namespace G
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Validate Examples<br/>
        /// Validate an example.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ExampleValidationResult>> ValidateExamplesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}