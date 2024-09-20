//HintName: G.Models.OnboardingStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OnboardingStatus describes the status of the user onboarding process.<br/>
    ///  - ONBOARDING_STATUS_IN_PROGRESS: In progress, i.e., the user has initiated the onboarding process<br/>
    /// but has not yet completed it.<br/>
    ///  - ONBOARDING_STATUS_COMPLETED: Completed.
    /// </summary>
    public enum OnboardingStatus
    {
        /// <summary>
        /// 
        /// </summary>
        ONBOARDINGSTATUSINPROGRESS,
        /// <summary>
        /// 
        /// </summary>
        ONBOARDINGSTATUSCOMPLETED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OnboardingStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OnboardingStatus value)
        {
            return value switch
            {
                OnboardingStatus.ONBOARDINGSTATUSINPROGRESS => "ONBOARDING_STATUS_IN_PROGRESS",
                OnboardingStatus.ONBOARDINGSTATUSCOMPLETED => "ONBOARDING_STATUS_COMPLETED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OnboardingStatus? ToEnum(string value)
        {
            return value switch
            {
                "ONBOARDING_STATUS_IN_PROGRESS" => OnboardingStatus.ONBOARDINGSTATUSINPROGRESS,
                "ONBOARDING_STATUS_COMPLETED" => OnboardingStatus.ONBOARDINGSTATUSCOMPLETED,
                _ => null,
            };
        }
    }
}