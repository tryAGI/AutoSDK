//HintName: G.Models.PagesHttpsCertificateState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: approved
    /// </summary>
    public enum PagesHttpsCertificateState
    {
        /// <summary>
        /// 
        /// </summary>
        Approved,
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
        AuthorizationRevoked,
        /// <summary>
        /// 
        /// </summary>
        Authorized,
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
        /// <summary>
        /// 
        /// </summary>
        Errored,
        /// <summary>
        /// 
        /// </summary>
        Issued,
        /// <summary>
        /// 
        /// </summary>
        New,
        /// <summary>
        /// 
        /// </summary>
        Uploaded,
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
                PagesHttpsCertificateState.Approved => "approved",
                PagesHttpsCertificateState.AuthorizationCreated => "authorization_created",
                PagesHttpsCertificateState.AuthorizationPending => "authorization_pending",
                PagesHttpsCertificateState.AuthorizationRevoked => "authorization_revoked",
                PagesHttpsCertificateState.Authorized => "authorized",
                PagesHttpsCertificateState.BadAuthz => "bad_authz",
                PagesHttpsCertificateState.DestroyPending => "destroy_pending",
                PagesHttpsCertificateState.DnsChanged => "dns_changed",
                PagesHttpsCertificateState.Errored => "errored",
                PagesHttpsCertificateState.Issued => "issued",
                PagesHttpsCertificateState.New => "new",
                PagesHttpsCertificateState.Uploaded => "uploaded",
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
                "approved" => PagesHttpsCertificateState.Approved,
                "authorization_created" => PagesHttpsCertificateState.AuthorizationCreated,
                "authorization_pending" => PagesHttpsCertificateState.AuthorizationPending,
                "authorization_revoked" => PagesHttpsCertificateState.AuthorizationRevoked,
                "authorized" => PagesHttpsCertificateState.Authorized,
                "bad_authz" => PagesHttpsCertificateState.BadAuthz,
                "destroy_pending" => PagesHttpsCertificateState.DestroyPending,
                "dns_changed" => PagesHttpsCertificateState.DnsChanged,
                "errored" => PagesHttpsCertificateState.Errored,
                "issued" => PagesHttpsCertificateState.Issued,
                "new" => PagesHttpsCertificateState.New,
                "uploaded" => PagesHttpsCertificateState.Uploaded,
                _ => null,
            };
        }
    }
}