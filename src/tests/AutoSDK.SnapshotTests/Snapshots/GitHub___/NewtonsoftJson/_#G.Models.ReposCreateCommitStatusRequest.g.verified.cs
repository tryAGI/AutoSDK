//HintName: G.Models.ReposCreateCommitStatusRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateCommitStatusRequest
    {
        /// <summary>
        /// The state of the status.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ReposCreateCommitStatusRequestState State { get; set; } = default!;

        /// <summary>
        /// The target URL to associate with this status. This URL will be linked from the GitHub UI to allow users to easily see the source of the status.  <br/>
        /// For example, if your continuous integration system is posting build status, you would want to provide the deep link for the build output for this specific SHA:  <br/>
        /// `http://ci.example.com/user/repo/build/sha`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_url")]
        public string? TargetUrl { get; set; }

        /// <summary>
        /// A short description of the status.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A string label to differentiate this status from the status of other systems. This field is case-insensitive.<br/>
        /// Default Value: default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public string? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateCommitStatusRequest" /> class.
        /// </summary>
        /// <param name="state">
        /// The state of the status.
        /// </param>
        /// <param name="targetUrl">
        /// The target URL to associate with this status. This URL will be linked from the GitHub UI to allow users to easily see the source of the status.  <br/>
        /// For example, if your continuous integration system is posting build status, you would want to provide the deep link for the build output for this specific SHA:  <br/>
        /// `http://ci.example.com/user/repo/build/sha`
        /// </param>
        /// <param name="description">
        /// A short description of the status.
        /// </param>
        /// <param name="context">
        /// A string label to differentiate this status from the status of other systems. This field is case-insensitive.<br/>
        /// Default Value: default
        /// </param>
        public ReposCreateCommitStatusRequest(
            global::G.ReposCreateCommitStatusRequestState state,
            string? targetUrl,
            string? description,
            string? context)
        {
            this.State = state;
            this.TargetUrl = targetUrl;
            this.Description = description;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateCommitStatusRequest" /> class.
        /// </summary>
        public ReposCreateCommitStatusRequest()
        {
        }
    }
}