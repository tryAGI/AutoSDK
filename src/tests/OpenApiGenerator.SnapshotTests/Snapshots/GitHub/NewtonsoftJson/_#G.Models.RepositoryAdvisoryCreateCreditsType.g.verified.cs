//HintName: G.Models.RepositoryAdvisoryCreateCreditsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of credit the user is receiving.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryAdvisoryCreateCreditsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="analyst")]
        Analyst,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="finder")]
        Finder,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reporter")]
        Reporter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="coordinator")]
        Coordinator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="remediation_developer")]
        RemediationDeveloper,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="remediation_reviewer")]
        RemediationReviewer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="remediation_verifier")]
        RemediationVerifier,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sponsor")]
        Sponsor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="other")]
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryAdvisoryCreateCreditsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryAdvisoryCreateCreditsType value)
        {
            return value switch
            {
                RepositoryAdvisoryCreateCreditsType.Analyst => "analyst",
                RepositoryAdvisoryCreateCreditsType.Finder => "finder",
                RepositoryAdvisoryCreateCreditsType.Reporter => "reporter",
                RepositoryAdvisoryCreateCreditsType.Coordinator => "coordinator",
                RepositoryAdvisoryCreateCreditsType.RemediationDeveloper => "remediation_developer",
                RepositoryAdvisoryCreateCreditsType.RemediationReviewer => "remediation_reviewer",
                RepositoryAdvisoryCreateCreditsType.RemediationVerifier => "remediation_verifier",
                RepositoryAdvisoryCreateCreditsType.Tool => "tool",
                RepositoryAdvisoryCreateCreditsType.Sponsor => "sponsor",
                RepositoryAdvisoryCreateCreditsType.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryAdvisoryCreateCreditsType ToEnum(string value)
        {
            return value switch
            {
                "analyst" => RepositoryAdvisoryCreateCreditsType.Analyst,
                "finder" => RepositoryAdvisoryCreateCreditsType.Finder,
                "reporter" => RepositoryAdvisoryCreateCreditsType.Reporter,
                "coordinator" => RepositoryAdvisoryCreateCreditsType.Coordinator,
                "remediation_developer" => RepositoryAdvisoryCreateCreditsType.RemediationDeveloper,
                "remediation_reviewer" => RepositoryAdvisoryCreateCreditsType.RemediationReviewer,
                "remediation_verifier" => RepositoryAdvisoryCreateCreditsType.RemediationVerifier,
                "tool" => RepositoryAdvisoryCreateCreditsType.Tool,
                "sponsor" => RepositoryAdvisoryCreateCreditsType.Sponsor,
                "other" => RepositoryAdvisoryCreateCreditsType.Other,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}