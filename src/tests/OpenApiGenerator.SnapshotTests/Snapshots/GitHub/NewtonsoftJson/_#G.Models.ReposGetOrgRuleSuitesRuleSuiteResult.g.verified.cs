//HintName: G.Models.ReposGetOrgRuleSuitesRuleSuiteResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: all
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposGetOrgRuleSuitesRuleSuiteResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pass")]
        Pass,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fail")]
        Fail,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bypass")]
        Bypass,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposGetOrgRuleSuitesRuleSuiteResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposGetOrgRuleSuitesRuleSuiteResult value)
        {
            return value switch
            {
                ReposGetOrgRuleSuitesRuleSuiteResult.Pass => "pass",
                ReposGetOrgRuleSuitesRuleSuiteResult.Fail => "fail",
                ReposGetOrgRuleSuitesRuleSuiteResult.Bypass => "bypass",
                ReposGetOrgRuleSuitesRuleSuiteResult.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposGetOrgRuleSuitesRuleSuiteResult ToEnum(string value)
        {
            return value switch
            {
                "pass" => ReposGetOrgRuleSuitesRuleSuiteResult.Pass,
                "fail" => ReposGetOrgRuleSuitesRuleSuiteResult.Fail,
                "bypass" => ReposGetOrgRuleSuitesRuleSuiteResult.Bypass,
                "all" => ReposGetOrgRuleSuitesRuleSuiteResult.All,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}