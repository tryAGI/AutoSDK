//HintName: G.Models.TeamsListMembersLegacyRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum TeamsListMembersLegacyRole
    {
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        Maintainer,
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamsListMembersLegacyRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsListMembersLegacyRole value)
        {
            return value switch
            {
                TeamsListMembersLegacyRole.Member => "member",
                TeamsListMembersLegacyRole.Maintainer => "maintainer",
                TeamsListMembersLegacyRole.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsListMembersLegacyRole? ToEnum(string value)
        {
            return value switch
            {
                "member" => TeamsListMembersLegacyRole.Member,
                "maintainer" => TeamsListMembersLegacyRole.Maintainer,
                "all" => TeamsListMembersLegacyRole.All,
                _ => null,
            };
        }
    }
}