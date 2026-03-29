//HintName: G.Models.ParseConfigurationUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for updating an existing parse configuration.
    /// </summary>
    public sealed partial class ParseConfigurationUpdate
    {
        /// <summary>
        /// Updated LlamaParseParameters configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::G.LlamaParseParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseConfigurationUpdate" /> class.
        /// </summary>
        /// <param name="parameters">
        /// Updated LlamaParseParameters configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseConfigurationUpdate(
            global::G.LlamaParseParameters? parameters)
        {
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseConfigurationUpdate" /> class.
        /// </summary>
        public ParseConfigurationUpdate()
        {
        }
    }
}