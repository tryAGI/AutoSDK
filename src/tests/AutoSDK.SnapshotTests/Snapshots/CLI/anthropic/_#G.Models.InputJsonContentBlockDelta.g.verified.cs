//HintName: G.Models.InputJsonContentBlockDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InputJsonContentBlockDelta
    {
        /// <summary>
        /// Default Value: input_json_delta
        /// </summary>
        /// <default>global::G.InputJsonContentBlockDeltaType.InputJsonDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InputJsonContentBlockDeltaTypeJsonConverter))]
        public global::G.InputJsonContentBlockDeltaType Type { get; set; } = global::G.InputJsonContentBlockDeltaType.InputJsonDelta;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PartialJson { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputJsonContentBlockDelta" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: input_json_delta
        /// </param>
        /// <param name="partialJson"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputJsonContentBlockDelta(
            string partialJson,
            global::G.InputJsonContentBlockDeltaType type = global::G.InputJsonContentBlockDeltaType.InputJsonDelta)
        {
            this.PartialJson = partialJson ?? throw new global::System.ArgumentNullException(nameof(partialJson));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputJsonContentBlockDelta" /> class.
        /// </summary>
        public InputJsonContentBlockDelta()
        {
        }
    }
}