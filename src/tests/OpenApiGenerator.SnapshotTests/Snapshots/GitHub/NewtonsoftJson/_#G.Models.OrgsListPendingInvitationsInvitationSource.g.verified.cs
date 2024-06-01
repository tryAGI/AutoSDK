//HintName: G.Models.OrgsListPendingInvitationsInvitationSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: all
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgsListPendingInvitationsInvitationSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scim")]
        Scim,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsListPendingInvitationsInvitationSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsListPendingInvitationsInvitationSource value)
        {
            return value switch
            {
                OrgsListPendingInvitationsInvitationSource.All => "all",
                OrgsListPendingInvitationsInvitationSource.Member => "member",
                OrgsListPendingInvitationsInvitationSource.Scim => "scim",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsListPendingInvitationsInvitationSource ToEnum(string value)
        {
            return value switch
            {
                "all" => OrgsListPendingInvitationsInvitationSource.All,
                "member" => OrgsListPendingInvitationsInvitationSource.Member,
                "scim" => OrgsListPendingInvitationsInvitationSource.Scim,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}