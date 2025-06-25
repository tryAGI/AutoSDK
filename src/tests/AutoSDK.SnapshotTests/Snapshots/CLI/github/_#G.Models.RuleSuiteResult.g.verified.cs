﻿//HintName: G.Models.RuleSuiteResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the rule evaluations for rules with the `active` enforcement status.
    /// </summary>
    public enum RuleSuiteResult
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RuleSuiteResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuleSuiteResult value)
        {
            return value switch
            {
                RuleSuiteResult.Pass => "pass",
                RuleSuiteResult.Fail => "fail",
                RuleSuiteResult.Bypass => "bypass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuleSuiteResult? ToEnum(string value)
        {
            return value switch
            {
                "pass" => RuleSuiteResult.Pass,
                "fail" => RuleSuiteResult.Fail,
                "bypass" => RuleSuiteResult.Bypass,
                _ => null,
            };
        }
    }
}