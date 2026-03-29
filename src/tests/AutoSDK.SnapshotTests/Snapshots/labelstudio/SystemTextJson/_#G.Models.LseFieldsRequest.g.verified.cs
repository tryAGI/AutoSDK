//HintName: G.Models.LseFieldsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LseFieldsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite_activated")]
        public bool? InviteActivated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invited_at")]
        public global::System.DateTime? InvitedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invited_by")]
        public int? InvitedBy { get; set; }

        /// <summary>
        /// The current stage of user onboarding<br/>
        /// * `not_started` - Not Started<br/>
        /// * `signup` - Signup<br/>
        /// * `trial_signup` - Trial Signup<br/>
        /// * `first_tutorial` - First Tutorial<br/>
        /// * `in_app_guidance` - In App Guidance<br/>
        /// * `complete` - Complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onboarding_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OnboardingStateEnumJsonConverter))]
        public global::G.OnboardingStateEnum? OnboardingState { get; set; }

        /// <summary>
        /// Is user finished social authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("social_auth_finished")]
        public bool? SocialAuthFinished { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trial_company")]
        public string? TrialCompany { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trial_experience_labeling")]
        public string? TrialExperienceLabeling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trial_license_enterprise")]
        public bool? TrialLicenseEnterprise { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trial_models_in_production")]
        public string? TrialModelsInProduction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trial_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TrialRoleEnumJsonConverter))]
        public global::G.TrialRoleEnum? TrialRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseFieldsRequest" /> class.
        /// </summary>
        /// <param name="inviteActivated"></param>
        /// <param name="invitedAt"></param>
        /// <param name="invitedBy"></param>
        /// <param name="onboardingState">
        /// The current stage of user onboarding<br/>
        /// * `not_started` - Not Started<br/>
        /// * `signup` - Signup<br/>
        /// * `trial_signup` - Trial Signup<br/>
        /// * `first_tutorial` - First Tutorial<br/>
        /// * `in_app_guidance` - In App Guidance<br/>
        /// * `complete` - Complete
        /// </param>
        /// <param name="socialAuthFinished">
        /// Is user finished social authentication
        /// </param>
        /// <param name="trialCompany"></param>
        /// <param name="trialExperienceLabeling"></param>
        /// <param name="trialLicenseEnterprise"></param>
        /// <param name="trialModelsInProduction"></param>
        /// <param name="trialRole"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseFieldsRequest(
            bool? inviteActivated,
            global::System.DateTime? invitedAt,
            int? invitedBy,
            global::G.OnboardingStateEnum? onboardingState,
            bool? socialAuthFinished,
            string? trialCompany,
            string? trialExperienceLabeling,
            bool? trialLicenseEnterprise,
            string? trialModelsInProduction,
            global::G.TrialRoleEnum? trialRole)
        {
            this.InviteActivated = inviteActivated;
            this.InvitedAt = invitedAt;
            this.InvitedBy = invitedBy;
            this.OnboardingState = onboardingState;
            this.SocialAuthFinished = socialAuthFinished;
            this.TrialCompany = trialCompany;
            this.TrialExperienceLabeling = trialExperienceLabeling;
            this.TrialLicenseEnterprise = trialLicenseEnterprise;
            this.TrialModelsInProduction = trialModelsInProduction;
            this.TrialRole = trialRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseFieldsRequest" /> class.
        /// </summary>
        public LseFieldsRequest()
        {
        }
    }
}