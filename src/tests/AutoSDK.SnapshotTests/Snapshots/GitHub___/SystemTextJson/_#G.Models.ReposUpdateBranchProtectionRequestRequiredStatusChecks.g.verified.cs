//HintName: G.Models.ReposUpdateBranchProtectionRequestRequiredStatusChecks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Require status checks to pass before merging. Set to `null` to disable.
    /// </summary>
    public sealed partial class ReposUpdateBranchProtectionRequestRequiredStatusChecks
    {
        /// <summary>
        /// Require branches to be up to date before merging.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Strict { get; set; }

        /// <summary>
        /// **Deprecated**: The list of status checks to require in order to merge into this branch. If any of these checks have recently been set by a particular GitHub App, they will be required to come from that app in future for the branch to merge. Use `checks` instead of `contexts` for more fine-grained control.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contexts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Contexts { get; set; }

        /// <summary>
        /// The list of status checks to require in order to merge into this branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        public global::System.Collections.Generic.IList<global::G.ReposUpdateBranchProtectionRequestRequiredStatusChecksCheck>? Checks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateBranchProtectionRequestRequiredStatusChecks" /> class.
        /// </summary>
        /// <param name="strict">
        /// Require branches to be up to date before merging.
        /// </param>
        /// <param name="contexts">
        /// **Deprecated**: The list of status checks to require in order to merge into this branch. If any of these checks have recently been set by a particular GitHub App, they will be required to come from that app in future for the branch to merge. Use `checks` instead of `contexts` for more fine-grained control.
        /// </param>
        /// <param name="checks">
        /// The list of status checks to require in order to merge into this branch.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReposUpdateBranchProtectionRequestRequiredStatusChecks(
            bool strict,
            global::System.Collections.Generic.IList<string> contexts,
            global::System.Collections.Generic.IList<global::G.ReposUpdateBranchProtectionRequestRequiredStatusChecksCheck>? checks)
        {
            this.Strict = strict;
            this.Contexts = contexts ?? throw new global::System.ArgumentNullException(nameof(contexts));
            this.Checks = checks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateBranchProtectionRequestRequiredStatusChecks" /> class.
        /// </summary>
        public ReposUpdateBranchProtectionRequestRequiredStatusChecks()
        {
        }
    }
}