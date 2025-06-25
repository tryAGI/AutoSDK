﻿//HintName: G.Models.RealtimeResponseUsageOutputTokenDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details about the output tokens used in the Response.
    /// </summary>
    public sealed partial class RealtimeResponseUsageOutputTokenDetails
    {
        /// <summary>
        /// The number of text tokens used in the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_tokens")]
        public int? TextTokens { get; set; }

        /// <summary>
        /// The number of audio tokens used in the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_tokens")]
        public int? AudioTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseUsageOutputTokenDetails" /> class.
        /// </summary>
        /// <param name="textTokens">
        /// The number of text tokens used in the Response.
        /// </param>
        /// <param name="audioTokens">
        /// The number of audio tokens used in the Response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseUsageOutputTokenDetails(
            int? textTokens,
            int? audioTokens)
        {
            this.TextTokens = textTokens;
            this.AudioTokens = audioTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseUsageOutputTokenDetails" /> class.
        /// </summary>
        public RealtimeResponseUsageOutputTokenDetails()
        {
        }
    }
}