//HintName: G.Models.MappedStopEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MappedStopEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MappedStopEvent" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MappedStopEvent(
            string kind,
            string? reason)
        {
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MappedStopEvent" /> class.
        /// </summary>
        public MappedStopEvent()
        {
        }

    }
}