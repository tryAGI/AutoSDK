//HintName: G.Models.PreventSelfReview.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether or not a user who created the job is prevented from approving their own job.
    /// <br/>Example: false
    /// </summary>
    public sealed partial class PreventSelfReview
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}