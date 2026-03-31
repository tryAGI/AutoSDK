//HintName: G.Models.JsonSchemaCreateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for creating a JSON schema.
    /// </summary>
    public sealed partial class JsonSchemaCreateParams
    {
        /// <summary>
        /// Description of the data to extract
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaCreateParams" /> class.
        /// </summary>
        /// <param name="description">
        /// Description of the data to extract
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JsonSchemaCreateParams(
            string description)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaCreateParams" /> class.
        /// </summary>
        public JsonSchemaCreateParams()
        {
        }
    }
}