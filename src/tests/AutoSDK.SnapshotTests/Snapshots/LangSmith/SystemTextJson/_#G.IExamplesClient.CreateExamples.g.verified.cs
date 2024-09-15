//HintName: G.IExamplesClient.CreateExamples.g.cs
#nullable enable

namespace G
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Create Examples<br/>
        /// Create a new example.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Example>> CreateExamplesAsync(
            global::System.Collections.Generic.IList<global::G.ExampleBulkCreate> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}