//HintName: G.Models.ListJobsAfter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Job ID cursor for pagination. Returns jobs that come after this job ID in the specified sort order
    /// </summary>
    public sealed partial class ListJobsAfter
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}