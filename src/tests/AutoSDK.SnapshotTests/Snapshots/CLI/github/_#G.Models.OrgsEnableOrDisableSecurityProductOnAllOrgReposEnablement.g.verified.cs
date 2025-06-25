//HintName: G.Models.OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement
    {
        /// <summary>
        /// 
        /// </summary>
        EnableAll,
        /// <summary>
        /// 
        /// </summary>
        DisableAll,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement value)
        {
            return value switch
            {
                OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement.EnableAll => "enable_all",
                OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement.DisableAll => "disable_all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement? ToEnum(string value)
        {
            return value switch
            {
                "enable_all" => OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement.EnableAll,
                "disable_all" => OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement.DisableAll,
                _ => null,
            };
        }
    }
}