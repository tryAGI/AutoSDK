﻿//HintName: G.Models.UltravoxV1InCallTimespan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A timespan during a call.
    /// </summary>
    public sealed partial class UltravoxV1InCallTimespan
    {
        /// <summary>
        /// The offset relative to the start of the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public string? Start { get; set; }

        /// <summary>
        /// The offset relative to the start of the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public string? End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1InCallTimespan" /> class.
        /// </summary>
        /// <param name="start">
        /// The offset relative to the start of the call.
        /// </param>
        /// <param name="end">
        /// The offset relative to the start of the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1InCallTimespan(
            string? start,
            string? end)
        {
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1InCallTimespan" /> class.
        /// </summary>
        public UltravoxV1InCallTimespan()
        {
        }
    }
}