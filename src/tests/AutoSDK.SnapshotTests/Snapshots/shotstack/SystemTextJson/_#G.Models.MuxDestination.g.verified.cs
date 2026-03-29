//HintName: G.Models.MuxDestination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send videos to the [Mux](https://shotstack.io/docs/guide/serving-assets/destinations/mux/) video hosting and streaming service. Mux credentials are required and added via the [dashboard](https://dashboard.shotstack.io/integrations/mux), not in the request.
    /// </summary>
    public sealed partial class MuxDestination
    {
        /// <summary>
        /// The destination to send video to - set to `mux` for Mux.<br/>
        /// Default Value: mux<br/>
        /// Example: mux
        /// </summary>
        /// <default>"mux"</default>
        /// <example>mux</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; } = "mux";

        /// <summary>
        /// Pass additional options to control how Mux processes video. Currently supports playback_policy and passthrough options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::G.MuxDestinationOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MuxDestination" /> class.
        /// </summary>
        /// <param name="provider">
        /// The destination to send video to - set to `mux` for Mux.<br/>
        /// Default Value: mux<br/>
        /// Example: mux
        /// </param>
        /// <param name="options">
        /// Pass additional options to control how Mux processes video. Currently supports playback_policy and passthrough options.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MuxDestination(
            string provider,
            global::G.MuxDestinationOptions? options)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MuxDestination" /> class.
        /// </summary>
        public MuxDestination()
        {
        }
    }
}