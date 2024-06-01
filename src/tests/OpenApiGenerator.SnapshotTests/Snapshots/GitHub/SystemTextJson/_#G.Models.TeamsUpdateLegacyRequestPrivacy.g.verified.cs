//HintName: G.Models.TeamsUpdateLegacyRequestPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of privacy this team should have. Editing teams without specifying this parameter leaves `privacy` intact. The options are:  
    /// **For a non-nested team:**  
    ///  * `secret` - only visible to organization owners and members of this team.  
    ///  * `closed` - visible to all members of this organization.  
    /// **For a parent or child team:**  
    ///  * `closed` - visible to all members of this organization.
    /// </summary>
    public enum TeamsUpdateLegacyRequestPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        Secret,
        /// <summary>
        /// 
        /// </summary>
        Closed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamsUpdateLegacyRequestPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsUpdateLegacyRequestPrivacy value)
        {
            return value switch
            {
                TeamsUpdateLegacyRequestPrivacy.Secret => "secret",
                TeamsUpdateLegacyRequestPrivacy.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsUpdateLegacyRequestPrivacy ToEnum(string value)
        {
            return value switch
            {
                "secret" => TeamsUpdateLegacyRequestPrivacy.Secret,
                "closed" => TeamsUpdateLegacyRequestPrivacy.Closed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}