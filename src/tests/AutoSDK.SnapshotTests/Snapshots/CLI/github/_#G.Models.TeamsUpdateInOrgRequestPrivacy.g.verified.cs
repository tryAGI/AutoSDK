﻿//HintName: G.Models.TeamsUpdateInOrgRequestPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of privacy this team should have. Editing teams without specifying this parameter leaves `privacy` intact. When a team is nested, the `privacy` for parent teams cannot be `secret`. The options are:  <br/>
    /// **For a non-nested team:**  <br/>
    ///  * `secret` - only visible to organization owners and members of this team.  <br/>
    ///  * `closed` - visible to all members of this organization.  <br/>
    /// **For a parent or child team:**  <br/>
    ///  * `closed` - visible to all members of this organization.
    /// </summary>
    public enum TeamsUpdateInOrgRequestPrivacy
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
    public static class TeamsUpdateInOrgRequestPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsUpdateInOrgRequestPrivacy value)
        {
            return value switch
            {
                TeamsUpdateInOrgRequestPrivacy.Secret => "secret",
                TeamsUpdateInOrgRequestPrivacy.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsUpdateInOrgRequestPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "secret" => TeamsUpdateInOrgRequestPrivacy.Secret,
                "closed" => TeamsUpdateInOrgRequestPrivacy.Closed,
                _ => null,
            };
        }
    }
}