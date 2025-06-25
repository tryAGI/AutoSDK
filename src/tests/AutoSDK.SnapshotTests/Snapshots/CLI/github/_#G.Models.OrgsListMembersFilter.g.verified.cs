//HintName: G.Models.OrgsListMembersFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum OrgsListMembersFilter
    {
        /// <summary>
        /// //github.com/blog/1614-two-factor-authentication) enabled will be returned. This options is only available for organization owners.
        /// </summary>
        x2faDisabled,
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsListMembersFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsListMembersFilter value)
        {
            return value switch
            {
                OrgsListMembersFilter.x2faDisabled => "2fa_disabled",
                OrgsListMembersFilter.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsListMembersFilter? ToEnum(string value)
        {
            return value switch
            {
                "2fa_disabled" => OrgsListMembersFilter.x2faDisabled,
                "all" => OrgsListMembersFilter.All,
                _ => null,
            };
        }
    }
}