//HintName: G.Models.GraphQLResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GraphQL based response: http://facebook.github.io/graphql/.
    /// </summary>
    public sealed partial class GraphQLResponse
    {
        /// <summary>
        /// GraphQL data object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.Dictionary<string, object>? Data { get; set; }

        /// <summary>
        /// Array with errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::G.GraphQLError>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphQLResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// GraphQL data object.
        /// </param>
        /// <param name="errors">
        /// Array with errors.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphQLResponse(
            global::System.Collections.Generic.Dictionary<string, object>? data,
            global::System.Collections.Generic.IList<global::G.GraphQLError>? errors)
        {
            this.Data = data;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphQLResponse" /> class.
        /// </summary>
        public GraphQLResponse()
        {
        }
    }
}