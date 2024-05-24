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
}