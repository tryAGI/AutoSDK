//HintName: G.Models.OTELTraceResourceSpanScopeSpanSpanStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OTELTraceResourceSpanScopeSpanSpanStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public double Code { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanScopeSpanSpanStatus" /> class.
        /// </summary>
        /// <param name="code"></param>
        public OTELTraceResourceSpanScopeSpanSpanStatus(
            double code)
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanScopeSpanSpanStatus" /> class.
        /// </summary>
        public OTELTraceResourceSpanScopeSpanSpanStatus()
        {
        }
    }
}