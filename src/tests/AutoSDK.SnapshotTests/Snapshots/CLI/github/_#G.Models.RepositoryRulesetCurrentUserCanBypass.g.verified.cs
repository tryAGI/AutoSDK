﻿//HintName: G.Models.RepositoryRulesetCurrentUserCanBypass.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The bypass type of the user making the API request for this ruleset. This field is only returned when<br/>
    /// querying the repository-level endpoint.
    /// </summary>
    public enum RepositoryRulesetCurrentUserCanBypass
    {
        /// <summary>
        /// 
        /// </summary>
        Always,
        /// <summary>
        /// 
        /// </summary>
        PullRequestsOnly,
        /// <summary>
        /// 
        /// </summary>
        Never,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRulesetCurrentUserCanBypassExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRulesetCurrentUserCanBypass value)
        {
            return value switch
            {
                RepositoryRulesetCurrentUserCanBypass.Always => "always",
                RepositoryRulesetCurrentUserCanBypass.PullRequestsOnly => "pull_requests_only",
                RepositoryRulesetCurrentUserCanBypass.Never => "never",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRulesetCurrentUserCanBypass? ToEnum(string value)
        {
            return value switch
            {
                "always" => RepositoryRulesetCurrentUserCanBypass.Always,
                "pull_requests_only" => RepositoryRulesetCurrentUserCanBypass.PullRequestsOnly,
                "never" => RepositoryRulesetCurrentUserCanBypass.Never,
                _ => null,
            };
        }
    }
}