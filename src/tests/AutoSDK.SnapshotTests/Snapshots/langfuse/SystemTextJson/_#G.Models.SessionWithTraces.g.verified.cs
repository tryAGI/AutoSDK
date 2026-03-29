//HintName: G.Models.SessionWithTraces.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionWithTraces
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Trace> Traces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionWithTraces" /> class.
        /// </summary>
        /// <param name="traces"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionWithTraces(
            global::System.Collections.Generic.IList<global::G.Trace> traces)
        {
            this.Traces = traces ?? throw new global::System.ArgumentNullException(nameof(traces));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionWithTraces" /> class.
        /// </summary>
        public SessionWithTraces()
        {
        }
    }
}