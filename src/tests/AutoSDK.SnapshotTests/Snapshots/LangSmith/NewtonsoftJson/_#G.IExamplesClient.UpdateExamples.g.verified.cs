//HintName: G.IExamplesClient.UpdateExamples.g.cs
#nullable enable

namespace G
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Update Examples<br/>
        /// Update examples in bulk.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateExamplesAsync(
            global::System.Collections.Generic.IList<global::G.ExampleUpdateWithID> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}