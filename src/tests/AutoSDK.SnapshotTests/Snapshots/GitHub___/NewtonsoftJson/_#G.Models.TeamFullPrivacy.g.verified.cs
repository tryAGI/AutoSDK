//HintName: G.Models.TeamFullPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of privacy this team should have<br/>
    /// Example: closed
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TeamFullPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret")]
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamFullPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamFullPrivacy value)
        {
            return value switch
            {
                TeamFullPrivacy.Closed => "closed",
                TeamFullPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamFullPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "closed" => TeamFullPrivacy.Closed,
                "secret" => TeamFullPrivacy.Secret,
                _ => null,
            };
        }
    }
}