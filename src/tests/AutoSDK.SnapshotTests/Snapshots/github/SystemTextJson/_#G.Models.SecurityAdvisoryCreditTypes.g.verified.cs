//HintName: G.Models.SecurityAdvisoryCreditTypes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of credit the user is receiving.
    /// </summary>
    public enum SecurityAdvisoryCreditTypes
    {
        /// <summary>
        /// 
        /// </summary>
        Analyst,
        /// <summary>
        /// 
        /// </summary>
        Coordinator,
        /// <summary>
        /// 
        /// </summary>
        Finder,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        RemediationDeveloper,
        /// <summary>
        /// 
        /// </summary>
        RemediationReviewer,
        /// <summary>
        /// 
        /// </summary>
        RemediationVerifier,
        /// <summary>
        /// 
        /// </summary>
        Reporter,
        /// <summary>
        /// 
        /// </summary>
        Sponsor,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecurityAdvisoryCreditTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAdvisoryCreditTypes value)
        {
            return value switch
            {
                SecurityAdvisoryCreditTypes.Analyst => "analyst",
                SecurityAdvisoryCreditTypes.Coordinator => "coordinator",
                SecurityAdvisoryCreditTypes.Finder => "finder",
                SecurityAdvisoryCreditTypes.Other => "other",
                SecurityAdvisoryCreditTypes.RemediationDeveloper => "remediation_developer",
                SecurityAdvisoryCreditTypes.RemediationReviewer => "remediation_reviewer",
                SecurityAdvisoryCreditTypes.RemediationVerifier => "remediation_verifier",
                SecurityAdvisoryCreditTypes.Reporter => "reporter",
                SecurityAdvisoryCreditTypes.Sponsor => "sponsor",
                SecurityAdvisoryCreditTypes.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAdvisoryCreditTypes? ToEnum(string value)
        {
            return value switch
            {
                "analyst" => SecurityAdvisoryCreditTypes.Analyst,
                "coordinator" => SecurityAdvisoryCreditTypes.Coordinator,
                "finder" => SecurityAdvisoryCreditTypes.Finder,
                "other" => SecurityAdvisoryCreditTypes.Other,
                "remediation_developer" => SecurityAdvisoryCreditTypes.RemediationDeveloper,
                "remediation_reviewer" => SecurityAdvisoryCreditTypes.RemediationReviewer,
                "remediation_verifier" => SecurityAdvisoryCreditTypes.RemediationVerifier,
                "reporter" => SecurityAdvisoryCreditTypes.Reporter,
                "sponsor" => SecurityAdvisoryCreditTypes.Sponsor,
                "tool" => SecurityAdvisoryCreditTypes.Tool,
                _ => null,
            };
        }
    }
}