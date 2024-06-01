//HintName: G.Models.RepositoryAdvisoryCreditType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of credit the user is receiving.
    /// </summary>
    public enum RepositoryAdvisoryCreditType
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
    public static class RepositoryAdvisoryCreditTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryAdvisoryCreditType value)
        {
            return value switch
            {
                RepositoryAdvisoryCreditType.Analyst => "analyst",
                RepositoryAdvisoryCreditType.Finder => "finder",
                RepositoryAdvisoryCreditType.Reporter => "reporter",
                RepositoryAdvisoryCreditType.Coordinator => "coordinator",
                RepositoryAdvisoryCreditType.RemediationDeveloper => "remediation_developer",
                RepositoryAdvisoryCreditType.RemediationReviewer => "remediation_reviewer",
                RepositoryAdvisoryCreditType.RemediationVerifier => "remediation_verifier",
                RepositoryAdvisoryCreditType.Tool => "tool",
                RepositoryAdvisoryCreditType.Sponsor => "sponsor",
                RepositoryAdvisoryCreditType.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryAdvisoryCreditType ToEnum(string value)
        {
            return value switch
            {
                "analyst" => RepositoryAdvisoryCreditType.Analyst,
                "finder" => RepositoryAdvisoryCreditType.Finder,
                "reporter" => RepositoryAdvisoryCreditType.Reporter,
                "coordinator" => RepositoryAdvisoryCreditType.Coordinator,
                "remediation_developer" => RepositoryAdvisoryCreditType.RemediationDeveloper,
                "remediation_reviewer" => RepositoryAdvisoryCreditType.RemediationReviewer,
                "remediation_verifier" => RepositoryAdvisoryCreditType.RemediationVerifier,
                "tool" => RepositoryAdvisoryCreditType.Tool,
                "sponsor" => RepositoryAdvisoryCreditType.Sponsor,
                "other" => RepositoryAdvisoryCreditType.Other,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}