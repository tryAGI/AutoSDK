//HintName: G.Models.MuxDestinationOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pass additional options to control how Mux processes video. Currently supports playback_policy and passthrough options.
    /// </summary>
    public sealed partial class MuxDestinationOptions
    {
        /// <summary>
        /// Sets the Mux `playback_policy` option. Value is an array of strings - use `public`, `signed`, or both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playbackPolicy")]
        public global::System.Collections.Generic.IList<global::G.MuxDestinationOptionsPlaybackPolicyItem>? PlaybackPolicy { get; set; }

        /// <summary>
        /// Sets the Mux `passthrough` option. Max 255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passthrough")]
        public string? Passthrough { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MuxDestinationOptions" /> class.
        /// </summary>
        /// <param name="playbackPolicy">
        /// Sets the Mux `playback_policy` option. Value is an array of strings - use `public`, `signed`, or both.
        /// </param>
        /// <param name="passthrough">
        /// Sets the Mux `passthrough` option. Max 255 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MuxDestinationOptions(
            global::System.Collections.Generic.IList<global::G.MuxDestinationOptionsPlaybackPolicyItem>? playbackPolicy,
            string? passthrough)
        {
            this.PlaybackPolicy = playbackPolicy;
            this.Passthrough = passthrough;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MuxDestinationOptions" /> class.
        /// </summary>
        public MuxDestinationOptions()
        {
        }
    }
}