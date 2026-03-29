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
        [global::Newtonsoft.Json.JsonProperty("traces", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Trace> Traces { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionWithTraces" /> class.
        /// </summary>
        /// <param name="traces"></param>
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