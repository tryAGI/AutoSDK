//HintName: G.IApi.Authorizations.MutualTls.g.cs

#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Marks this client as using the configured mutual TLS certificate for the MutualTlsAuth scheme.
        /// </summary>
        public void AuthorizeUsingMutualTls();

        /// <summary>
        /// Configures a client certificate for mutual TLS when this client owns the HttpClient instance.
        /// </summary>
        /// <param name="clientCertificate"></param>
        public void ConfigureMutualTlsClientCertificate(
            global::System.Security.Cryptography.X509Certificates.X509Certificate2 clientCertificate);

        /// <summary>
        /// Configures multiple client certificates for mutual TLS when this client owns the HttpClient instance.
        /// </summary>
        /// <param name="clientCertificates"></param>
        public void ConfigureMutualTlsClientCertificates(
            global::System.Collections.Generic.IEnumerable<global::System.Security.Cryptography.X509Certificates.X509Certificate2> clientCertificates);
    }
}