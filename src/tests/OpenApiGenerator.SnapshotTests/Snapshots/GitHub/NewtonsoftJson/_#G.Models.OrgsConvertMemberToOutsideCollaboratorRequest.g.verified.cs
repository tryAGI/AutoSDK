//HintName: G.Models.OrgsConvertMemberToOutsideCollaboratorRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsConvertMemberToOutsideCollaboratorRequest
    {
        /// <summary>
        /// When set to `true`, the request will be performed asynchronously. Returns a 202 status code when the job is successfully queued.
        /// <br/>Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("async")]
        public bool Async { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}