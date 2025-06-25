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
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// **Deprecated**: The list of status checks to require in order to merge into this branch. If any of these checks have recently been set by a particular GitHub App, they will be required to come from that app in future for the branch to merge. Use `checks` instead of `contexts` for more fine-grained control.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contexts")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? Contexts { get; set; }

        /// <summary>
        /// The list of status checks to require in order to merge into this branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        public global::System.Collections.Generic.IList<global::G.ReposUpdateStatusCheckProtectionRequestCheck>? Checks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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