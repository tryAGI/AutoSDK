//HintName: G.Models.StudioLlmModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StudioLlmModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::G.JsonNode? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioLlmModel" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StudioLlmModel(
            string model,
            global::G.JsonNode? parameters)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioLlmModel" /> class.
        /// </summary>
        public StudioLlmModel()
        {
        }
    }
}