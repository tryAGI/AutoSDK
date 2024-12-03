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
        /// When set to `true`, the request will be performed asynchronously. Returns a 202 status code when the job is successfully queued.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        public bool? Async { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsConvertMemberToOutsideCollaboratorRequest" /> class.
        /// </summary>
        /// <param name="async">
        /// When set to `true`, the request will be performed asynchronously. Returns a 202 status code when the job is successfully queued.<br/>
        /// Default Value: false
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OrgsConvertMemberToOutsideCollaboratorRequest(
            bool? async)
        {
            this.Async = async;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsConvertMemberToOutsideCollaboratorRequest" /> class.
        /// </summary>
        public OrgsConvertMemberToOutsideCollaboratorRequest()
        {
        }
    }
}