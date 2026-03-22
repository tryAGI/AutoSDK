//HintName: G.Models.ReposGetOrgRuleSuitesRuleSuiteResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposGetOrgRuleSuitesRuleSuiteResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bypass")]
        Bypass,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fail")]
        Fail,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pass")]
        Pass,
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
                ReposGetOrgRuleSuitesRuleSuiteResult.All => "all",
                ReposGetOrgRuleSuitesRuleSuiteResult.Bypass => "bypass",
                ReposGetOrgRuleSuitesRuleSuiteResult.Fail => "fail",
                ReposGetOrgRuleSuitesRuleSuiteResult.Pass => "pass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposGetOrgRuleSuitesRuleSuiteResult? ToEnum(string value)
        {
            return value switch
            {
                "all" => ReposGetOrgRuleSuitesRuleSuiteResult.All,
                "bypass" => ReposGetOrgRuleSuitesRuleSuiteResult.Bypass,
                "fail" => ReposGetOrgRuleSuitesRuleSuiteResult.Fail,
                "pass" => ReposGetOrgRuleSuitesRuleSuiteResult.Pass,
                _ => null,
            };
        }
    }
}