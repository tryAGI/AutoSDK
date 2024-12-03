//HintName: G.Models.ReposUpdateStatusCheckProtectionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposUpdateStatusCheckProtectionRequest
    {
        /// <summary>
        /// Require branches to be up to date before merging.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// **Deprecated**: The list of status checks to require in order to merge into this branch. If any of these checks have recently been set by a particular GitHub App, they will be required to come from that app in future for the branch to merge. Use `checks` instead of `contexts` for more fine-grained control.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contexts")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? Contexts { get; set; }

        /// <summary>
        /// The list of status checks to require in order to merge into this branch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("checks")]
        public global::System.Collections.Generic.IList<global::G.ReposUpdateStatusCheckProtectionRequestCheck>? Checks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateStatusCheckProtectionRequest" /> class.
        /// </summary>
        /// <param name="strict">
        /// Require branches to be up to date before merging.
        /// </param>
        /// <param name="checks">
        /// The list of status checks to require in order to merge into this branch.
        /// </param>
        public ReposUpdateStatusCheckProtectionRequest(
            bool? strict,
            global::System.Collections.Generic.IList<global::G.ReposUpdateStatusCheckProtectionRequestCheck>? checks)
        {
            this.Strict = strict;
            this.Checks = checks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateStatusCheckProtectionRequest" /> class.
        /// </summary>
        public ReposUpdateStatusCheckProtectionRequest()
        {
        }
    }
}