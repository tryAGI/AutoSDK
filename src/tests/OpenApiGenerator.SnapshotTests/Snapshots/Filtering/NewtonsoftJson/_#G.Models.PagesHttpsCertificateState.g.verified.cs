//HintName: G.Models.PagesHttpsCertificateState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Example: approved
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PagesHttpsCertificateState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="new")]
        New,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="authorization_created")]
        AuthorizationCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="authorization_pending")]
        AuthorizationPending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="authorized")]
        Authorized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="authorization_revoked")]
        AuthorizationRevoked,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="issued")]
        Issued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uploaded")]
        Uploaded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="approved")]
        Approved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="errored")]
        Errored,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bad_authz")]
        BadAuthz,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="destroy_pending")]
        DestroyPending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dns_changed")]
        DnsChanged,
    }

    public static class PagesHttpsCertificateStateExtensions
    {
        public static string ToValueString(this PagesHttpsCertificateState value)
        {
            return value switch
            {
                PagesHttpsCertificateState.New => "new",
                PagesHttpsCertificateState.AuthorizationCreated => "authorization_created",
                PagesHttpsCertificateState.AuthorizationPending => "authorization_pending",
                PagesHttpsCertificateState.Authorized => "authorized",
                PagesHttpsCertificateState.AuthorizationRevoked => "authorization_revoked",
                PagesHttpsCertificateState.Issued => "issued",
                PagesHttpsCertificateState.Uploaded => "uploaded",
                PagesHttpsCertificateState.Approved => "approved",
                PagesHttpsCertificateState.Errored => "errored",
                PagesHttpsCertificateState.BadAuthz => "bad_authz",
                PagesHttpsCertificateState.DestroyPending => "destroy_pending",
                PagesHttpsCertificateState.DnsChanged => "dns_changed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static PagesHttpsCertificateState ToEnum(string value)
        {
            return value switch
            {
                "new" => PagesHttpsCertificateState.New,
                "authorization_created" => PagesHttpsCertificateState.AuthorizationCreated,
                "authorization_pending" => PagesHttpsCertificateState.AuthorizationPending,
                "authorized" => PagesHttpsCertificateState.Authorized,
                "authorization_revoked" => PagesHttpsCertificateState.AuthorizationRevoked,
                "issued" => PagesHttpsCertificateState.Issued,
                "uploaded" => PagesHttpsCertificateState.Uploaded,
                "approved" => PagesHttpsCertificateState.Approved,
                "errored" => PagesHttpsCertificateState.Errored,
                "bad_authz" => PagesHttpsCertificateState.BadAuthz,
                "destroy_pending" => PagesHttpsCertificateState.DestroyPending,
                "dns_changed" => PagesHttpsCertificateState.DnsChanged,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static PagesHttpsCertificateState ToEnum(int value)
        {
            return value switch
            {
                0 => PagesHttpsCertificateState.New,
                1 => PagesHttpsCertificateState.AuthorizationCreated,
                2 => PagesHttpsCertificateState.AuthorizationPending,
                3 => PagesHttpsCertificateState.Authorized,
                4 => PagesHttpsCertificateState.AuthorizationRevoked,
                5 => PagesHttpsCertificateState.Issued,
                6 => PagesHttpsCertificateState.Uploaded,
                7 => PagesHttpsCertificateState.Approved,
                8 => PagesHttpsCertificateState.Errored,
                9 => PagesHttpsCertificateState.BadAuthz,
                10 => PagesHttpsCertificateState.DestroyPending,
                11 => PagesHttpsCertificateState.DnsChanged,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}