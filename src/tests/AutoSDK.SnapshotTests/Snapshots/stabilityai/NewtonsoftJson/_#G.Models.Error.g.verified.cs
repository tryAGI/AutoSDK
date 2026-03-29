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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The short-name of this class of errors e.g. `bad_request`.<br/>
        /// Example: bad_request
        /// </summary>
        /// <example>bad_request</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A human-readable explanation specific to this occurrence of the problem.<br/>
        /// Example: Header parameter Authorization is required, but not found
        /// </summary>
        /// <example>Header parameter Authorization is required, but not found</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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