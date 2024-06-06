﻿//HintName: G.Models.ReposGetRepoRuleSuitesResponseResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the rule evaluations for rules with the `active` enforcement status.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposGetRepoRuleSuitesResponseResult
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposGetRepoRuleSuitesResponseResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposGetRepoRuleSuitesResponseResult value)
        {
            return value switch
            {
                ReposGetRepoRuleSuitesResponseResult.Pass => "pass",
                ReposGetRepoRuleSuitesResponseResult.Fail => "fail",
                ReposGetRepoRuleSuitesResponseResult.Bypass => "bypass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposGetRepoRuleSuitesResponseResult ToEnum(string value)
        {
            return value switch
            {
                "pass" => ReposGetRepoRuleSuitesResponseResult.Pass,
                "fail" => ReposGetRepoRuleSuitesResponseResult.Fail,
                "bypass" => ReposGetRepoRuleSuitesResponseResult.Bypass,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}