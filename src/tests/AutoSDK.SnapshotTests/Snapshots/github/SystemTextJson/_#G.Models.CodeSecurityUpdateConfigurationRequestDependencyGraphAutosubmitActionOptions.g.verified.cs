//HintName: G.Models.CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitActionOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Feature options for Automatic dependency submission
    /// </summary>
    public sealed partial class CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitActionOptions
    {
        /// <summary>
        /// Whether to use runners labeled with 'dependency-submission' or standard GitHub runners.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labeled_runners")]
        public bool? LabeledRunners { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitActionOptions" /> class.
        /// </summary>
        /// <param name="labeledRunners">
        /// Whether to use runners labeled with 'dependency-submission' or standard GitHub runners.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitActionOptions(
            bool? labeledRunners)
        {
            this.LabeledRunners = labeledRunners;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitActionOptions" /> class.
        /// </summary>
        public CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitActionOptions()
        {
        }
    }
}