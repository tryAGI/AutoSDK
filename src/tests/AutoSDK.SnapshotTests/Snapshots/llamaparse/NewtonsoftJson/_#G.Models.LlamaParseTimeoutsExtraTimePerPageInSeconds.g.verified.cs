//HintName: G.Models.LlamaParseTimeoutsExtraTimePerPageInSeconds.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Additional timeout per page in seconds (max 300 = 5 minutes). Total timeout = base + (this value × page count)
    /// </summary>
    public sealed partial class LlamaParseTimeoutsExtraTimePerPageInSeconds
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}