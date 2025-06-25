//HintName: G.Models.GraphQLQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GraphQL query based on: http://facebook.github.io/graphql/.
    /// </summary>
    public sealed partial class GraphQLQuery
    {
        /// <summary>
        /// The name of the operation if multiple exist in the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operationName")]
        public string? OperationName { get; set; }

        /// <summary>
        /// Query based on GraphQL syntax.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Additional variables for the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public object? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphQLQuery" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphQLQuery(
            string? operationName,
            string? query,
            object? variables)
        {
            this.OperationName = operationName;
            this.Query = query;
            this.Variables = variables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphQLQuery" /> class.
        /// </summary>
        public GraphQLQuery()
        {
        }
    }
}