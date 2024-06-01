//HintName: G.Models.GlobalAdvisoryCreditsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of credit the user is receiving.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GlobalAdvisoryCreditsType
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
    public static class GlobalAdvisoryCreditsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GlobalAdvisoryCreditsType value)
        {
            return value switch
            {
                GlobalAdvisoryCreditsType.Analyst => "analyst",
                GlobalAdvisoryCreditsType.Finder => "finder",
                GlobalAdvisoryCreditsType.Reporter => "reporter",
                GlobalAdvisoryCreditsType.Coordinator => "coordinator",
                GlobalAdvisoryCreditsType.RemediationDeveloper => "remediation_developer",
                GlobalAdvisoryCreditsType.RemediationReviewer => "remediation_reviewer",
                GlobalAdvisoryCreditsType.RemediationVerifier => "remediation_verifier",
                GlobalAdvisoryCreditsType.Tool => "tool",
                GlobalAdvisoryCreditsType.Sponsor => "sponsor",
                GlobalAdvisoryCreditsType.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GlobalAdvisoryCreditsType ToEnum(string value)
        {
            return value switch
            {
                "analyst" => GlobalAdvisoryCreditsType.Analyst,
                "finder" => GlobalAdvisoryCreditsType.Finder,
                "reporter" => GlobalAdvisoryCreditsType.Reporter,
                "coordinator" => GlobalAdvisoryCreditsType.Coordinator,
                "remediation_developer" => GlobalAdvisoryCreditsType.RemediationDeveloper,
                "remediation_reviewer" => GlobalAdvisoryCreditsType.RemediationReviewer,
                "remediation_verifier" => GlobalAdvisoryCreditsType.RemediationVerifier,
                "tool" => GlobalAdvisoryCreditsType.Tool,
                "sponsor" => GlobalAdvisoryCreditsType.Sponsor,
                "other" => GlobalAdvisoryCreditsType.Other,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}