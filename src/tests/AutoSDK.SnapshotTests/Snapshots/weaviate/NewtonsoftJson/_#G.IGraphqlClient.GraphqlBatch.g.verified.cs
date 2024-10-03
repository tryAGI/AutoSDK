//HintName: G.IGraphqlClient.GraphqlBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IGraphqlClient
    {
        /// <summary>
        /// Perform batched GraphQL queries.<br/>
        /// Perform batched GraphQL query
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.GraphQLResponse>> GraphqlBatchAsync(
            global::System.Collections.Generic.IList<global::G.GraphQLQuery> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}