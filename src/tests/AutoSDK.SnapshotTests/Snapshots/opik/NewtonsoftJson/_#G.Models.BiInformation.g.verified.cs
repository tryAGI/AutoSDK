//HintName: G.Models.BiInformation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BiInformation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public string? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BiInformation" /> class.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="user"></param>
        /// <param name="count"></param>
        public BiInformation(
            string? workspaceId,
            string? user,
            long? count)
        {
            this.WorkspaceId = workspaceId;
            this.User = user;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BiInformation" /> class.
        /// </summary>
        public BiInformation()
        {
        }
    }
}