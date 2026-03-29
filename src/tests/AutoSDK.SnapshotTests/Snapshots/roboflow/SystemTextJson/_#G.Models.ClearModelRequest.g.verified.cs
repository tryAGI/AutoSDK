//HintName: G.Models.ClearModelRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to clear a model from the inference server.<br/>
    /// Attributes:<br/>
    ///     model_id (str): A unique model identifier.
    /// </summary>
    public sealed partial class ClearModelRequest
    {
        /// <summary>
        /// A unique model identifier<br/>
        /// Example: raccoon-detector-1
        /// </summary>
        /// <example>raccoon-detector-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClearModelRequest" /> class.
        /// </summary>
        /// <param name="modelId">
        /// A unique model identifier<br/>
        /// Example: raccoon-detector-1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClearModelRequest(
            string modelId)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClearModelRequest" /> class.
        /// </summary>
        public ClearModelRequest()
        {
        }
    }
}