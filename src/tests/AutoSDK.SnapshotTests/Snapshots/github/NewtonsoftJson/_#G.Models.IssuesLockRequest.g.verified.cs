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
        /// The reason for locking the issue or pull request conversation. Lock will fail if you don't use one of these reasons:  <br/>
        ///  * `off-topic`  <br/>
        ///  * `too heated`  <br/>
        ///  * `resolved`  <br/>
        ///  * `spam`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lock_reason")]
        public global::G.IssuesLockRequestLockReason? LockReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesLockRequest" /> class.
        /// </summary>
        /// <param name="lockReason">
        /// The reason for locking the issue or pull request conversation. Lock will fail if you don't use one of these reasons:  <br/>
        ///  * `off-topic`  <br/>
        ///  * `too heated`  <br/>
        ///  * `resolved`  <br/>
        ///  * `spam`
        /// </param>
        public IssuesLockRequest(
            global::G.IssuesLockRequestLockReason? lockReason)
        {
            this.LockReason = lockReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesLockRequest" /> class.
        /// </summary>
        public IssuesLockRequest()
        {
        }
    }
}