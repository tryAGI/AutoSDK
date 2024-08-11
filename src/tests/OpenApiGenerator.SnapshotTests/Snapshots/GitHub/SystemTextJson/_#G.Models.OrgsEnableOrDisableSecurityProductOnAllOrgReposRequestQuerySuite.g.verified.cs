//HintName: G.Models.OrgsEnableOrDisableSecurityProductOnAllOrgReposRequestQuerySuite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CodeQL query suite to be used. If you specify the `query_suite` parameter, the default setup will be configured with this query suite only on all repositories that didn't have default setup already configured. It will not change the query suite on repositories that already have default setup configured.<br/>
    /// If you don't specify any `query_suite` in your request, the preferred query suite of the organization will be applied.
    /// </summary>
    public enum OrgsEnableOrDisableSecurityProductOnAllOrgReposRequestQuerySuite
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Extended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsEnableOrDisableSecurityProductOnAllOrgReposRequestQuerySuiteExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsEnableOrDisableSecurityProductOnAllOrgReposRequestQuerySuite value)
        {
            return value switch
            {
                OrgsEnableOrDisableSecurityProductOnAllOrgReposRequestQuerySuite.Default => "default",
                OrgsEnableOrDisableSecurityProductOnAllOrgReposRequestQuerySuite.Extended => "extended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsEnableOrDisableSecurityProductOnAllOrgReposRequestQuerySuite? ToEnum(string value)
        {
            return value switch
            {
                "default" => OrgsEnableOrDisableSecurityProductOnAllOrgReposRequestQuerySuite.Default,
                "extended" => OrgsEnableOrDisableSecurityProductOnAllOrgReposRequestQuerySuite.Extended,
                _ => null,
            };
        }
    }
}