//HintName: G.Models.PagesHttpsCertificateState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Example: approved
    /// </summary>
    public enum PagesHttpsCertificateState
    {
        /// <summary>
        /// 
        /// </summary>
        New,
        /// <summary>
        /// 
        /// </summary>
        AuthorizationCreated,
        /// <summary>
        /// 
        /// </summary>
        AuthorizationPending,
        /// <summary>
        /// 
        /// </summary>
        Authorized,
        /// <summary>
        /// 
        /// </summary>
        AuthorizationRevoked,
        /// <summary>
        /// 
        /// </summary>
        Issued,
        /// <summary>
        /// 
        /// </summary>
        Uploaded,
        /// <summary>
        /// 
        /// </summary>
        Approved,
        /// <summary>
        /// 
        /// </summary>
        Errored,
        /// <summary>
        /// 
        /// </summary>
        BadAuthz,
        /// <summary>
        /// 
        /// </summary>
        DestroyPending,
        /// <summary>
        /// 
        /// </summary>
        DnsChanged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PagesHttpsCertificateStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PagesHttpsCertificateState? ToEnum(string value)
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
                _ => null,
            };
        }
    }
}