//HintName: G.IGraphqlClient.GraphqlPost.g.cs
#nullable enable

namespace G
{
    public partial interface IGraphqlClient
    {
        /// <summary>
        /// Perform a GraphQL query.<br/>
        /// Get a response based on a GraphQL query
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GraphQLResponse> GraphqlPostAsync(
            global::G.GraphQLQuery request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Perform a GraphQL query.<br/>
        /// Get a response based on a GraphQL query
        /// </summary>
        /// <param name="operationName">
        /// The name of the operation if multiple exist in the query.
        /// </param>
        /// <param name="query">
        /// Query based on GraphQL syntax.
        /// </param>
        /// <param name="variables">
        /// Additional variables for the query.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GraphQLResponse> GraphqlPostAsync(
            string? operationName = default,
            string? query = default,
            object? variables = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}