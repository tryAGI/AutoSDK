//HintName: G.Models.RepositoryAdvisoryCreditType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of credit the user is receiving.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryAdvisoryCreditType
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