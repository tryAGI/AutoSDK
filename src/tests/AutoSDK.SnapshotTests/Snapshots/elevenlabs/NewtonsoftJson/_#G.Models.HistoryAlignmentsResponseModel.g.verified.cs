//HintName: G.Models.HistoryAlignmentsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HistoryAlignmentsResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alignment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.HistoryAlignmentResponseModel Alignment { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("normalized_alignment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.HistoryAlignmentResponseModel NormalizedAlignment { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}