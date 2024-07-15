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
        Finder,
        /// <summary>
        /// 
        /// </summary>
        Reporter,
        /// <summary>
        /// 
        /// </summary>
        Coordinator,
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
        Tool,
        /// <summary>
        /// 
        /// </summary>
        Sponsor,
        /// <summary>
        /// 
        /// </summary>
        Other,
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
                SecurityAdvisoryCreditTypes.Finder => "finder",
                SecurityAdvisoryCreditTypes.Reporter => "reporter",
                SecurityAdvisoryCreditTypes.Coordinator => "coordinator",
                SecurityAdvisoryCreditTypes.RemediationDeveloper => "remediation_developer",
                SecurityAdvisoryCreditTypes.RemediationReviewer => "remediation_reviewer",
                SecurityAdvisoryCreditTypes.RemediationVerifier => "remediation_verifier",
                SecurityAdvisoryCreditTypes.Tool => "tool",
                SecurityAdvisoryCreditTypes.Sponsor => "sponsor",
                SecurityAdvisoryCreditTypes.Other => "other",
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
                "finder" => SecurityAdvisoryCreditTypes.Finder,
                "reporter" => SecurityAdvisoryCreditTypes.Reporter,
                "coordinator" => SecurityAdvisoryCreditTypes.Coordinator,
                "remediation_developer" => SecurityAdvisoryCreditTypes.RemediationDeveloper,
                "remediation_reviewer" => SecurityAdvisoryCreditTypes.RemediationReviewer,
                "remediation_verifier" => SecurityAdvisoryCreditTypes.RemediationVerifier,
                "tool" => SecurityAdvisoryCreditTypes.Tool,
                "sponsor" => SecurityAdvisoryCreditTypes.Sponsor,
                "other" => SecurityAdvisoryCreditTypes.Other,
                _ => null,
            };
        }
    }
}