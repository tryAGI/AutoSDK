//HintName: G.Models.S3Destination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send videos and assets to an [Amazon S3](https://shotstack.io/docs/guide/serving-assets/destinations/s3/) bucket. Send files to any region with your own prefix and filename. AWS credentials are required and added via the [dashboard](https://dashboard.shotstack.io/integrations/s3), not in the request.
    /// </summary>
    public sealed partial class S3Destination
    {
        /// <summary>
        /// The destination to send assets to - set to `s3` for S3.<br/>
        /// Default Value: s3<br/>
        /// Example: s3
        /// </summary>
        /// <default>"s3"</default>
        /// <example>s3</example>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// Pass additional options to control how files are stored in S3.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public global::G.S3DestinationOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="S3Destination" /> class.
        /// </summary>
        /// <param name="provider">
        /// The destination to send assets to - set to `s3` for S3.<br/>
        /// Default Value: s3<br/>
        /// Example: s3
        /// </param>
        /// <param name="options">
        /// Pass additional options to control how files are stored in S3.
        /// </param>
        public S3Destination(
            string provider,
            global::G.S3DestinationOptions? options)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="S3Destination" /> class.
        /// </summary>
        public S3Destination()
        {
        }
    }
}