﻿//HintName: G.Models.ReposGetRepoRuleSuitesRuleSuiteResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum ReposGetRepoRuleSuitesRuleSuiteResult
    {
        /// <summary>
        /// 
        /// </summary>
        Pass,
        /// <summary>
        /// 
        /// </summary>
        Fail,
        /// <summary>
        /// 
        /// </summary>
        Bypass,
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposGetRepoRuleSuitesRuleSuiteResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposGetRepoRuleSuitesRuleSuiteResult value)
        {
            return value switch
            {
                ReposGetRepoRuleSuitesRuleSuiteResult.Pass => "pass",
                ReposGetRepoRuleSuitesRuleSuiteResult.Fail => "fail",
                ReposGetRepoRuleSuitesRuleSuiteResult.Bypass => "bypass",
                ReposGetRepoRuleSuitesRuleSuiteResult.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposGetRepoRuleSuitesRuleSuiteResult? ToEnum(string value)
        {
            return value switch
            {
                "pass" => ReposGetRepoRuleSuitesRuleSuiteResult.Pass,
                "fail" => ReposGetRepoRuleSuitesRuleSuiteResult.Fail,
                "bypass" => ReposGetRepoRuleSuitesRuleSuiteResult.Bypass,
                "all" => ReposGetRepoRuleSuitesRuleSuiteResult.All,
                _ => null,
            };
        }
    }
}