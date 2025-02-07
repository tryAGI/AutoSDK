//HintName: G.Models.GraphQLError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An error response caused by a GraphQL query.
    /// </summary>
    public sealed partial class GraphQLError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locations")]
        public global::System.Collections.Generic.IList<global::G.GraphQLErrorLocation>? Locations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public global::System.Collections.Generic.IList<string>? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphQLError" /> class.
        /// </summary>
        /// <param name="locations"></param>
        /// <param name="message"></param>
        /// <param name="path"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphQLError(
            global::System.Collections.Generic.IList<global::G.GraphQLErrorLocation>? locations,
            string? message,
            global::System.Collections.Generic.IList<string>? path)
        {
            this.Locations = locations;
            this.Message = message;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphQLError" /> class.
        /// </summary>
        public GraphQLError()
        {
        }
    }
}