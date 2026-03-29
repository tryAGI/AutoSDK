//HintName: G.Models.GenerationsGetGenerationResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generation response
    /// </summary>
    public sealed partial class GenerationsGetGenerationResponse200
    {
        /// <summary>
        /// Generation data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GenerationGetResponsesContentApplicationJsonSchemaData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationsGetGenerationResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// Generation data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationsGetGenerationResponse200(
            global::G.GenerationGetResponsesContentApplicationJsonSchemaData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationsGetGenerationResponse200" /> class.
        /// </summary>
        public GenerationsGetGenerationResponse200()
        {
        }
    }
}