//HintName: G.Models.AkamaiNetStorageDestination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send videos and assets to [Akamai NetStorage](https://techdocs.akamai.com/netstorage-usage/docs). Send files to your NetStorage upload directory with a custom path and filename. Akamai credentials are required and added via the [dashboard](https://dashboard.shotstack.io/integrations/akamai-netstorage), not in the request.
    /// </summary>
    public sealed partial class AkamaiNetStorageDestination
    {
        /// <summary>
        /// The destination to send assets to - set to `akamai-netstorage` for Akamai NetStorage.<br/>
        /// Default Value: akamai-netstorage<br/>
        /// Example: akamai-netstorage
        /// </summary>
        /// <default>"akamai-netstorage"</default>
        /// <example>akamai-netstorage</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; } = "akamai-netstorage";

        /// <summary>
        /// Pass additional options to control how files are stored in Akamai NetStorage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::G.AkamaiNetStorageDestinationOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AkamaiNetStorageDestination" /> class.
        /// </summary>
        /// <param name="provider">
        /// The destination to send assets to - set to `akamai-netstorage` for Akamai NetStorage.<br/>
        /// Default Value: akamai-netstorage<br/>
        /// Example: akamai-netstorage
        /// </param>
        /// <param name="options">
        /// Pass additional options to control how files are stored in Akamai NetStorage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AkamaiNetStorageDestination(
            string provider,
            global::G.AkamaiNetStorageDestinationOptions? options)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AkamaiNetStorageDestination" /> class.
        /// </summary>
        public AkamaiNetStorageDestination()
        {
        }
    }
}