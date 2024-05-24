//HintName: G.Models.PendingDeploymentReviewers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PendingDeploymentReviewers
    {
        /// <summary>
        /// The type of reviewer.
        /// <br/>Example: User
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public PendingDeploymentReviewersType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reviewer")]
        public object? Reviewer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}