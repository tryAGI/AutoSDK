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
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.Dictionary<string, object>? Data { get; set; }

        /// <summary>
        /// Array with errors.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors")]
        public global::System.Collections.Generic.IList<global::G.GraphQLError>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}