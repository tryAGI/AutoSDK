//HintName: G.Models.OtlpSpanStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An optional final status for this span. Semantically when Status isn't set, it means span's status code is unset, i.e. assume STATUS_CODE_UNSET (code = 0).
    /// </summary>
    public sealed partial class OtlpSpanStatus
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}