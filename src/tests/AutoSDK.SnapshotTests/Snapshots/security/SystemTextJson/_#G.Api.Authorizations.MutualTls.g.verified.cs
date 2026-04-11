//HintName: G.Api.Authorizations.MutualTls.g.cs

#nullable enable

namespace G
{
    public sealed partial class Api
    {
        /// <summary>
        /// Marks this client as using the configured mutual TLS certificate for the MutualTlsAuth scheme.
        /// If you supplied your own <see cref="global::System.Net.Http.HttpClient"/>, configure its handler externally before calling this method.
        /// </summary>
        public void AuthorizeUsingMutualTls()
        {
            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "MutualTLS" &&
                    __authorization.SchemeId == "MutualTlsAuth")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::G.EndPointAuthorization
            {
                Type = "MutualTLS",
                SchemeId = "MutualTlsAuth",
                Location = "",
                Name = "MutualTlsAuth",
                Value = string.Empty,
            });
        }

        /// <summary>
        /// Configures a client certificate for mutual TLS when this client owns the HttpClient instance.
        /// If you supplied your own HttpClient, configure its handler externally and then call AuthorizeUsingMutualTls().
        /// </summary>
        /// <param name="clientCertificate"></param>
        public void ConfigureMutualTlsClientCertificate(
            global::System.Security.Cryptography.X509Certificates.X509Certificate2 clientCertificate)
        {
            clientCertificate = clientCertificate ?? throw new global::System.ArgumentNullException(nameof(clientCertificate));

            if (_ownedHttpClientHandler is null)
            {
                throw new global::System.InvalidOperationException(
                    "Mutual TLS certificates can only be configured automatically when AutoSDK creates the HttpClient. Configure the handler on your supplied HttpClient and then call AuthorizeUsingMutualTls().");
            }

            _ownedHttpClientHandler.ClientCertificateOptions = global::System.Net.Http.ClientCertificateOption.Manual;
            _ownedHttpClientHandler.ClientCertificates.Add(clientCertificate);
            AuthorizeUsingMutualTls();
        }

        /// <summary>
        /// Configures multiple client certificates for mutual TLS when this client owns the HttpClient instance.
        /// If you supplied your own HttpClient, configure its handler externally and then call AuthorizeUsingMutualTls().
        /// </summary>
        /// <param name="clientCertificates"></param>
        public void ConfigureMutualTlsClientCertificates(
            global::System.Collections.Generic.IEnumerable<global::System.Security.Cryptography.X509Certificates.X509Certificate2> clientCertificates)
        {
            clientCertificates = clientCertificates ?? throw new global::System.ArgumentNullException(nameof(clientCertificates));

            if (_ownedHttpClientHandler is null)
            {
                throw new global::System.InvalidOperationException(
                    "Mutual TLS certificates can only be configured automatically when AutoSDK creates the HttpClient. Configure the handler on your supplied HttpClient and then call AuthorizeUsingMutualTls().");
            }

            var addedCertificate = false;
            _ownedHttpClientHandler.ClientCertificateOptions = global::System.Net.Http.ClientCertificateOption.Manual;

            foreach (var clientCertificate in clientCertificates)
            {
                if (clientCertificate is null)
                {
                    throw new global::System.ArgumentException("Client certificates cannot contain null values.", nameof(clientCertificates));
                }

                _ownedHttpClientHandler.ClientCertificates.Add(clientCertificate);
                addedCertificate = true;
            }

            if (!addedCertificate)
            {
                throw new global::System.ArgumentException("At least one client certificate must be provided.", nameof(clientCertificates));
            }

            AuthorizeUsingMutualTls();
        }
    }
}