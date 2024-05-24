//HintName: G.Models.RepositoryRulesetCurrentUserCanBypass.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The bypass type of the user making the API request for this ruleset. This field is only returned when
    /// querying the repository-level endpoint.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRulesetCurrentUserCanBypass
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="always")]
        Always,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pull_requests_only")]
        PullRequestsOnly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="never")]
        Never,
    }
}