//HintName: G.Models.ListJobsBefore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Job ID cursor for pagination. Returns jobs that come before this job ID in the specified sort order
    /// </summary>
    public sealed partial class ListJobsBefore
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}