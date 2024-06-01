//HintName: G.Models.IssuesLockRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesLockRequest
    {
        /// <summary>
        /// The reason for locking the issue or pull request conversation. Lock will fail if you don't use one of these reasons:  
        ///  * `off-topic`  
        ///  * `too heated`  
        ///  * `resolved`  
        ///  * `spam`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lock_reason")]
        public IssuesLockRequestLockReason? LockReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}