//HintName: G.Models.ClientToolSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for a client-side tool passed in the request.<br/>
    /// Client-side tools are executed by the client, not the server. When the agent<br/>
    /// calls a client-side tool, execution pauses and returns control to the client<br/>
    /// to execute the tool and provide the result.
    /// </summary>
    public sealed partial class ClientToolSchema
    {
        /// <summary>
        /// The name of the tool function
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of what the tool does
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// JSON Schema for the function parameters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolSchema" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the tool function
        /// </param>
        /// <param name="description">
        /// Description of what the tool does
        /// </param>
        /// <param name="parameters">
        /// JSON Schema for the function parameters
        /// </param>
        public ClientToolSchema(
            string name,
            string? description,
            object? parameters)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolSchema" /> class.
        /// </summary>
        public ClientToolSchema()
        {
        }
    }
}