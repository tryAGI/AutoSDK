﻿//HintName: G.Models.WordSearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WordSearchResponse
    {
        /// <summary>
        /// The ID of the transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The total count of all matched instances. For e.g., word 1 matched 2 times, and word 2 matched 3 times, `total_count` will equal 5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// The matches of the search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WordSearchMatch> Matches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordSearchResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the transcript
        /// </param>
        /// <param name="totalCount">
        /// The total count of all matched instances. For e.g., word 1 matched 2 times, and word 2 matched 3 times, `total_count` will equal 5.
        /// </param>
        /// <param name="matches">
        /// The matches of the search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WordSearchResponse(
            global::System.Guid id,
            int totalCount,
            global::System.Collections.Generic.IList<global::G.WordSearchMatch> matches)
        {
            this.Id = id;
            this.TotalCount = totalCount;
            this.Matches = matches ?? throw new global::System.ArgumentNullException(nameof(matches));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordSearchResponse" /> class.
        /// </summary>
        public WordSearchResponse()
        {
        }
    }
}