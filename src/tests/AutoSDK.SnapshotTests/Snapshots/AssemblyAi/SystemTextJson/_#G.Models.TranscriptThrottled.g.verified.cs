//HintName: G.Models.TranscriptThrottled.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// True while a request is throttled and false when a request is no longer throttled
    /// </summary>
    public sealed partial class TranscriptThrottled
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptThrottled" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TranscriptThrottled(
 )
        {
        }
    }
}