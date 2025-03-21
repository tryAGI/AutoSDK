//HintName: G.Models.Refusal.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A refusal from the model.
    /// </summary>
    public sealed partial class Refusal
    {
        /// <summary>
        /// The refusal explanationfrom the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Refusal1 { get; set; }

        /// <summary>
        /// The type of the refusal. Always `refusal`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RefusalTypeJsonConverter))]
        public global::G.RefusalType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Refusal" /> class.
        /// </summary>
        /// <param name="refusal1">
        /// The refusal explanationfrom the model.
        /// </param>
        /// <param name="type">
        /// The type of the refusal. Always `refusal`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Refusal(
            string refusal1,
            global::G.RefusalType type)
        {
            this.Refusal1 = refusal1 ?? throw new global::System.ArgumentNullException(nameof(refusal1));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Refusal" /> class.
        /// </summary>
        public Refusal()
        {
        }
    }
}