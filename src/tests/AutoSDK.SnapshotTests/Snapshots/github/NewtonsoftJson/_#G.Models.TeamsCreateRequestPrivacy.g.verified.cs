//HintName: G.Models.TeamsCreateRequestPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of privacy this team should have. The options are:  <br/>
    /// **For a non-nested team:**  <br/>
    ///  * `secret` - only visible to organization owners and members of this team.  <br/>
    ///  * `closed` - visible to all members of this organization.  <br/>
    /// Default: `secret`  <br/>
    /// **For a parent or child team:**  <br/>
    ///  * `closed` - visible to all members of this organization.  <br/>
    /// Default for child team: `closed`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TeamsCreateRequestPrivacy
    {
        /// <summary>
        /// `closed`
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// `secret`
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret")]
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamsCreateRequestPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsCreateRequestPrivacy value)
        {
            return value switch
            {
                TeamsCreateRequestPrivacy.Closed => "closed",
                TeamsCreateRequestPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsCreateRequestPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "closed" => TeamsCreateRequestPrivacy.Closed,
                "secret" => TeamsCreateRequestPrivacy.Secret,
                _ => null,
            };
        }
    }
}