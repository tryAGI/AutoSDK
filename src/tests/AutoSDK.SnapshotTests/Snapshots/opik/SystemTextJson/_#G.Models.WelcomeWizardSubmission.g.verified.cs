//HintName: G.Models.WelcomeWizardSubmission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WelcomeWizardSubmission
    {
        /// <summary>
        /// Optional user role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// List of integrations the user selected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::System.Collections.Generic.IList<string>? Integrations { get; set; }

        /// <summary>
        /// Optional user email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Whether user wants to join beta programs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("join_beta_program")]
        public bool? JoinBetaProgram { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WelcomeWizardSubmission" /> class.
        /// </summary>
        /// <param name="role">
        /// Optional user role
        /// </param>
        /// <param name="integrations">
        /// List of integrations the user selected
        /// </param>
        /// <param name="email">
        /// Optional user email
        /// </param>
        /// <param name="joinBetaProgram">
        /// Whether user wants to join beta programs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WelcomeWizardSubmission(
            string? role,
            global::System.Collections.Generic.IList<string>? integrations,
            string? email,
            bool? joinBetaProgram)
        {
            this.Role = role;
            this.Integrations = integrations;
            this.Email = email;
            this.JoinBetaProgram = joinBetaProgram;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WelcomeWizardSubmission" /> class.
        /// </summary>
        public WelcomeWizardSubmission()
        {
        }
    }
}