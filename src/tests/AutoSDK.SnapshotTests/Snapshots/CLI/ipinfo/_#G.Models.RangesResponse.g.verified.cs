﻿//HintName: G.Models.RangesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RangesResponse
    {
        /// <summary>
        /// Example: comcast.net
        /// </summary>
        /// <example>comcast.net</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// Example: 37330
        /// </summary>
        /// <example>37330</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_ranges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NumRanges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Ranges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RangesResponse" /> class.
        /// </summary>
        /// <param name="domain">
        /// Example: comcast.net
        /// </param>
        /// <param name="numRanges">
        /// Example: 37330
        /// </param>
        /// <param name="ranges"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RangesResponse(
            string domain,
            string numRanges,
            global::System.Collections.Generic.IList<string> ranges)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.NumRanges = numRanges ?? throw new global::System.ArgumentNullException(nameof(numRanges));
            this.Ranges = ranges ?? throw new global::System.ArgumentNullException(nameof(ranges));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangesResponse" /> class.
        /// </summary>
        public RangesResponse()
        {
        }
    }
}