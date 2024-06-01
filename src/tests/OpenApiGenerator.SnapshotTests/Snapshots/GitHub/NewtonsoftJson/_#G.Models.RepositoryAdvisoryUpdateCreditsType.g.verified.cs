//HintName: G.Models.RepositoryAdvisoryUpdateCreditsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of credit the user is receiving.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryAdvisoryUpdateCreditsType
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
    public static class RepositoryAdvisoryUpdateCreditsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryAdvisoryUpdateCreditsType value)
        {
            return value switch
            {
                RepositoryAdvisoryUpdateCreditsType.Analyst => "analyst",
                RepositoryAdvisoryUpdateCreditsType.Finder => "finder",
                RepositoryAdvisoryUpdateCreditsType.Reporter => "reporter",
                RepositoryAdvisoryUpdateCreditsType.Coordinator => "coordinator",
                RepositoryAdvisoryUpdateCreditsType.RemediationDeveloper => "remediation_developer",
                RepositoryAdvisoryUpdateCreditsType.RemediationReviewer => "remediation_reviewer",
                RepositoryAdvisoryUpdateCreditsType.RemediationVerifier => "remediation_verifier",
                RepositoryAdvisoryUpdateCreditsType.Tool => "tool",
                RepositoryAdvisoryUpdateCreditsType.Sponsor => "sponsor",
                RepositoryAdvisoryUpdateCreditsType.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryAdvisoryUpdateCreditsType ToEnum(string value)
        {
            return value switch
            {
                "analyst" => RepositoryAdvisoryUpdateCreditsType.Analyst,
                "finder" => RepositoryAdvisoryUpdateCreditsType.Finder,
                "reporter" => RepositoryAdvisoryUpdateCreditsType.Reporter,
                "coordinator" => RepositoryAdvisoryUpdateCreditsType.Coordinator,
                "remediation_developer" => RepositoryAdvisoryUpdateCreditsType.RemediationDeveloper,
                "remediation_reviewer" => RepositoryAdvisoryUpdateCreditsType.RemediationReviewer,
                "remediation_verifier" => RepositoryAdvisoryUpdateCreditsType.RemediationVerifier,
                "tool" => RepositoryAdvisoryUpdateCreditsType.Tool,
                "sponsor" => RepositoryAdvisoryUpdateCreditsType.Sponsor,
                "other" => RepositoryAdvisoryUpdateCreditsType.Other,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}