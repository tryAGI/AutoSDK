//HintName: G.Models.ReposGetRepoRuleSuitesRuleSuiteResult.g.cs

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
        All,
        /// <summary>
        /// 
        /// </summary>
        Bypass,
        /// <summary>
        /// 
        /// </summary>
        Fail,
        /// <summary>
        /// 
        /// </summary>
        Pass,
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
                ReposGetRepoRuleSuitesRuleSuiteResult.All => "all",
                ReposGetRepoRuleSuitesRuleSuiteResult.Bypass => "bypass",
                ReposGetRepoRuleSuitesRuleSuiteResult.Fail => "fail",
                ReposGetRepoRuleSuitesRuleSuiteResult.Pass => "pass",
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
                "all" => ReposGetRepoRuleSuitesRuleSuiteResult.All,
                "bypass" => ReposGetRepoRuleSuitesRuleSuiteResult.Bypass,
                "fail" => ReposGetRepoRuleSuitesRuleSuiteResult.Fail,
                "pass" => ReposGetRepoRuleSuitesRuleSuiteResult.Pass,
                _ => null,
            };
        }
    }
}