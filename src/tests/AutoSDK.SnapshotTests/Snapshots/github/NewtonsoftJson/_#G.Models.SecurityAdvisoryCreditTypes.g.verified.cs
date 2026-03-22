//HintName: G.Models.SecurityAdvisoryCreditTypes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of credit the user is receiving.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecurityAdvisoryCreditTypes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="analyst")]
        Analyst,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="coordinator")]
        Coordinator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="finder")]
        Finder,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="other")]
        Other,
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
        [global::System.Runtime.Serialization.EnumMember(Value="reporter")]
        Reporter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sponsor")]
        Sponsor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
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