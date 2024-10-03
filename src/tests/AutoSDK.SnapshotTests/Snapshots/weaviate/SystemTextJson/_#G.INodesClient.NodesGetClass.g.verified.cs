//HintName: G.INodesClient.NodesGetClass.g.cs
#nullable enable

namespace G
{
    public partial interface INodesClient
    {
        /// <summary>
        /// Node information for a collection.<br/>
        /// Returns node information for the nodes relevant to the collection.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="output">
        /// Default Value: minimal
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.NodesStatusResponse> NodesGetClassAsync(
            string className,
            global::G.NodesGetClassOutput? output = global::G.NodesGetClassOutput.Minimal,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}