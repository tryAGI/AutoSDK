//HintName: G.Models.SetupSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// SetupSchema defines the schema for a connection setup.<br/>
    /// This message is deprecated.
    /// </summary>
    public sealed partial class SetupSchema
    {
        /// <summary>
        /// The connection method, which will define the fields in the schema.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MethodJsonConverter))]
        public global::G.Method? Method { get; set; }

        /// <summary>
        /// The connection setup field definitions. Each integration will require<br/>
        /// different data to connect to the 3rd party app.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetupSchema" /> class.
        /// </summary>
        /// <param name="method">
        /// The connection method, which will define the fields in the schema.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="schema">
        /// The connection setup field definitions. Each integration will require<br/>
        /// different data to connect to the 3rd party app.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SetupSchema(
            global::G.Method? method,
            object? schema)
        {
            this.Method = method;
            this.Schema = schema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetupSchema" /> class.
        /// </summary>
        public SetupSchema()
        {
        }
    }
}