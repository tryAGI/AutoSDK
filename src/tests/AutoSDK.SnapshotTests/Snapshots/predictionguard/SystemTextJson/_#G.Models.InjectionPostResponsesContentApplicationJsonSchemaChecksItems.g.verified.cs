//HintName: G.Models.InjectionPostResponsesContentApplicationJsonSchemaChecksItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InjectionPostResponsesContentApplicationJsonSchemaChecksItems
    {
        /// <summary>
        /// The index position in the collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// The probability of a potential injection attack.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("probability")]
        public double? Probability { get; set; }

        /// <summary>
        /// The response if this choice was successful.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InjectionPostResponsesContentApplicationJsonSchemaChecksItems" /> class.
        /// </summary>
        /// <param name="index">
        /// The index position in the collection.
        /// </param>
        /// <param name="probability">
        /// The probability of a potential injection attack.
        /// </param>
        /// <param name="status">
        /// The response if this choice was successful.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InjectionPostResponsesContentApplicationJsonSchemaChecksItems(
            int? index,
            double? probability,
            string? status)
        {
            this.Index = index;
            this.Probability = probability;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InjectionPostResponsesContentApplicationJsonSchemaChecksItems" /> class.
        /// </summary>
        public InjectionPostResponsesContentApplicationJsonSchemaChecksItems()
        {
        }
    }
}