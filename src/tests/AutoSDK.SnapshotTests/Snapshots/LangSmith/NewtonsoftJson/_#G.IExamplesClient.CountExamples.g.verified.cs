//HintName: G.IExamplesClient.CountExamples.g.cs
#nullable enable

namespace G
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Count Examples<br/>
        /// Count all examples by query params
        /// </summary>
        /// <param name="id"></param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="fullTextContains"></param>
        /// <param name="splits"></param>
        /// <param name="dataset"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<int> CountExamplesAsync(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id = default,
            global::G.AnyOf<global::System.DateTime?, string>? asOf = default,
            global::G.AnyOf<string, object>? metadata = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, object>? fullTextContains = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, object>? splits = default,
            global::G.AnyOf<global::System.Guid?, object>? dataset = default,
            global::G.AnyOf<string, object>? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}