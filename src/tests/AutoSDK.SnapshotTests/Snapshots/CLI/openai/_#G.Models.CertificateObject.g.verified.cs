//HintName: G.Models.CertificateObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type.<br/>
    /// - If creating, updating, or getting a specific certificate, the object type is `certificate`.<br/>
    /// - If listing, activating, or deactivating certificates for the organization, the object type is `organization.certificate`.<br/>
    /// - If listing, activating, or deactivating certificates for a project, the object type is `organization.project.certificate`.
    /// </summary>
    public enum CertificateObject
    {
        /// <summary>
        /// 
        /// </summary>
        Certificate,
        /// <summary>
        /// 
        /// </summary>
        OrganizationCertificate,
        /// <summary>
        /// 
        /// </summary>
        OrganizationProjectCertificate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CertificateObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CertificateObject value)
        {
            return value switch
            {
                CertificateObject.Certificate => "certificate",
                CertificateObject.OrganizationCertificate => "organization.certificate",
                CertificateObject.OrganizationProjectCertificate => "organization.project.certificate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CertificateObject? ToEnum(string value)
        {
            return value switch
            {
                "certificate" => CertificateObject.Certificate,
                "organization.certificate" => CertificateObject.OrganizationCertificate,
                "organization.project.certificate" => CertificateObject.OrganizationProjectCertificate,
                _ => null,
            };
        }
    }
}