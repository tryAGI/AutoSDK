//HintName: G.Models.RepositoryAdvisoryCreditsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of credit the user is receiving.
    /// </summary>
    public enum RepositoryAdvisoryCreditsType
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
    public static class RepositoryAdvisoryCreditsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryAdvisoryCreditsType value)
        {
            return value switch
            {
                RepositoryAdvisoryCreditsType.Analyst => "analyst",
                RepositoryAdvisoryCreditsType.Finder => "finder",
                RepositoryAdvisoryCreditsType.Reporter => "reporter",
                RepositoryAdvisoryCreditsType.Coordinator => "coordinator",
                RepositoryAdvisoryCreditsType.RemediationDeveloper => "remediation_developer",
                RepositoryAdvisoryCreditsType.RemediationReviewer => "remediation_reviewer",
                RepositoryAdvisoryCreditsType.RemediationVerifier => "remediation_verifier",
                RepositoryAdvisoryCreditsType.Tool => "tool",
                RepositoryAdvisoryCreditsType.Sponsor => "sponsor",
                RepositoryAdvisoryCreditsType.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryAdvisoryCreditsType ToEnum(string value)
        {
            return value switch
            {
                "analyst" => RepositoryAdvisoryCreditsType.Analyst,
                "finder" => RepositoryAdvisoryCreditsType.Finder,
                "reporter" => RepositoryAdvisoryCreditsType.Reporter,
                "coordinator" => RepositoryAdvisoryCreditsType.Coordinator,
                "remediation_developer" => RepositoryAdvisoryCreditsType.RemediationDeveloper,
                "remediation_reviewer" => RepositoryAdvisoryCreditsType.RemediationReviewer,
                "remediation_verifier" => RepositoryAdvisoryCreditsType.RemediationVerifier,
                "tool" => RepositoryAdvisoryCreditsType.Tool,
                "sponsor" => RepositoryAdvisoryCreditsType.Sponsor,
                "other" => RepositoryAdvisoryCreditsType.Other,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}