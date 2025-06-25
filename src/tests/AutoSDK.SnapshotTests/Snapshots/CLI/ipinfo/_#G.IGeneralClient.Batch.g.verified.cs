//HintName: G.IGeneralClient.Batch.g.cs
#nullable enable

namespace G
{
    public partial interface IGeneralClient
    {
        /// <summary>
        /// Returns information about the selected values.<br/>
        /// Returns information about the selected values.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, object>> BatchAsync(
            global::System.Collections.Generic.IList<string> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}