//HintName: G.Models.Error.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Error
    {
        /// <summary>
        /// A unique identifier for this particular occurrence of the problem.<br/>
        /// Example: 296a972f-666a-44a1-a3df-c9c28a1f56c0
        /// </summary>
        /// <example>296a972f-666a-44a1-a3df-c9c28a1f56c0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The short-name of this class of errors e.g. `bad_request`.<br/>
        /// Example: bad_request
        /// </summary>
        /// <example>bad_request</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A human-readable explanation specific to this occurrence of the problem.<br/>
        /// Example: Header parameter Authorization is required, but not found
        /// </summary>
        /// <example>Header parameter Authorization is required, but not found</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for this particular occurrence of the problem.<br/>
        /// Example: 296a972f-666a-44a1-a3df-c9c28a1f56c0
        /// </param>
        /// <param name="name">
        /// The short-name of this class of errors e.g. `bad_request`.<br/>
        /// Example: bad_request
        /// </param>
        /// <param name="message">
        /// A human-readable explanation specific to this occurrence of the problem.<br/>
        /// Example: Header parameter Authorization is required, but not found
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Error(
            string id,
            string name,
            string message)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        public Error()
        {
        }
    }
}