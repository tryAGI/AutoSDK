//HintName: G.Models.OnboardingStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OnboardingStatus describes the status of the user onboarding process.<br/>
    ///  - ONBOARDING_STATUS_IN_PROGRESS: In progress, i.e., the user has initiated the onboarding process<br/>
    /// but has not yet completed it.<br/>
    ///  - ONBOARDING_STATUS_COMPLETED: Completed.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OnboardingStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ONBOARDING_STATUS_IN_PROGRESS")]
        ONBOARDINGSTATUSINPROGRESS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ONBOARDING_STATUS_COMPLETED")]
        ONBOARDINGSTATUSCOMPLETED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OnboardingStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OnboardingStatus2 value)
        {
            return value switch
            {
                OnboardingStatus2.ONBOARDINGSTATUSINPROGRESS => "ONBOARDING_STATUS_IN_PROGRESS",
                OnboardingStatus2.ONBOARDINGSTATUSCOMPLETED => "ONBOARDING_STATUS_COMPLETED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OnboardingStatus2? ToEnum(string value)
        {
            return value switch
            {
                "ONBOARDING_STATUS_IN_PROGRESS" => OnboardingStatus2.ONBOARDINGSTATUSINPROGRESS,
                "ONBOARDING_STATUS_COMPLETED" => OnboardingStatus2.ONBOARDINGSTATUSCOMPLETED,
                _ => null,
            };
        }
    }
}