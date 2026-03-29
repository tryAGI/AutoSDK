//HintName: G.Models.OnboardingStateEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `not_started` - Not Started<br/>
    /// * `signup` - Signup<br/>
    /// * `trial_signup` - Trial Signup<br/>
    /// * `first_tutorial` - First Tutorial<br/>
    /// * `in_app_guidance` - In App Guidance<br/>
    /// * `complete` - Complete
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OnboardingStateEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="complete")]
        Complete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="first_tutorial")]
        FirstTutorial,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_app_guidance")]
        InAppGuidance,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_started")]
        NotStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="signup")]
        Signup,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trial_signup")]
        TrialSignup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OnboardingStateEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OnboardingStateEnum value)
        {
            return value switch
            {
                OnboardingStateEnum.Complete => "complete",
                OnboardingStateEnum.FirstTutorial => "first_tutorial",
                OnboardingStateEnum.InAppGuidance => "in_app_guidance",
                OnboardingStateEnum.NotStarted => "not_started",
                OnboardingStateEnum.Signup => "signup",
                OnboardingStateEnum.TrialSignup => "trial_signup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OnboardingStateEnum? ToEnum(string value)
        {
            return value switch
            {
                "complete" => OnboardingStateEnum.Complete,
                "first_tutorial" => OnboardingStateEnum.FirstTutorial,
                "in_app_guidance" => OnboardingStateEnum.InAppGuidance,
                "not_started" => OnboardingStateEnum.NotStarted,
                "signup" => OnboardingStateEnum.Signup,
                "trial_signup" => OnboardingStateEnum.TrialSignup,
                _ => null,
            };
        }
    }
}