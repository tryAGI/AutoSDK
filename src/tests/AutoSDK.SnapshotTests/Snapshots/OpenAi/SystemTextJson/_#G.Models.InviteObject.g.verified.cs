//HintName: G.Models.InviteObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `organization.invite`
    /// </summary>
    public enum InviteObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationInvite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InviteObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InviteObject value)
        {
            return value switch
            {
                InviteObject.OrganizationInvite => "organization.invite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InviteObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.invite" => InviteObject.OrganizationInvite,
                _ => null,
            };
        }
    }
}