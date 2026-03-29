//HintName: G.Models.Hallucination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Hallucination
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.HallucinationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.HallucinationType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// true = minor hallucination, false/undefined = major hallucination (defaults to major for backward compatibility)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("low_severity")]
        public bool? LowSeverity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Hallucination" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="reason"></param>
        /// <param name="lowSeverity">
        /// true = minor hallucination, false/undefined = major hallucination (defaults to major for backward compatibility)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Hallucination(
            global::G.HallucinationType type,
            string reason,
            bool? lowSeverity)
        {
            this.Type = type;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.LowSeverity = lowSeverity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hallucination" /> class.
        /// </summary>
        public Hallucination()
        {
        }
    }
}