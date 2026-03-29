//HintName: G.Models.LlamaParseTimeoutsBaseInSeconds.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base timeout for the job in seconds (max 1800 = 30 minutes). This is the minimum time allowed regardless of document size
    /// </summary>
    public sealed partial class LlamaParseTimeoutsBaseInSeconds
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}