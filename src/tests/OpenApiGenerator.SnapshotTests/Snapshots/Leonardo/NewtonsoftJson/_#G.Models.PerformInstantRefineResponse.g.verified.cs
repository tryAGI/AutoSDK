//HintName: G.Models.PerformInstantRefineResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PerformInstantRefineResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lcmGenerationJob")]
        public global::G.PerformInstantRefineResponseLcmGenerationJob? LcmGenerationJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}