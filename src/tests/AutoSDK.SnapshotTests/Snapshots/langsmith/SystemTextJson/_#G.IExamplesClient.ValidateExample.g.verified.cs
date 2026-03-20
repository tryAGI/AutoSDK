//HintName: G.IExamplesClient.ValidateExample.g.cs
#nullable enable

namespace G
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Validate Example<br/>
        /// Validate an example.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExampleValidationResult> ValidateExampleAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}