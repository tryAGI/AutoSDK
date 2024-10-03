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
        [global::Newtonsoft.Json.JsonProperty("operationName")]
        public string? OperationName { get; set; }

        /// <summary>
        /// Query based on GraphQL syntax.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Additional variables for the query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variables")]
        public global::G.GraphQLQueryVariables? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}