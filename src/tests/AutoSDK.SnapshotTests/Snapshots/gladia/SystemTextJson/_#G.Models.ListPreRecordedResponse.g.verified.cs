//HintName: G.Models.ListPreRecordedResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListPreRecordedResponse
    {
        /// <summary>
        /// URL to fetch the first page<br/>
        /// Example: https://api.gladia.io/v2/transcription?status=done&amp;offset=0&amp;limit=20
        /// </summary>
        /// <example>https://api.gladia.io/v2/transcription?status=done&amp;offset=0&amp;limit=20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("first")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string First { get; set; }

        /// <summary>
        /// URL to fetch the current page<br/>
        /// Example: https://api.gladia.io/v2/transcription?status=done&amp;offset=0&amp;limit=20
        /// </summary>
        /// <example>https://api.gladia.io/v2/transcription?status=done&amp;offset=0&amp;limit=20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("current")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Current { get; set; }

        /// <summary>
        /// URL to fetch the next page<br/>
        /// Example: https://api.gladia.io/v2/transcription?status=done&amp;offset=20&amp;limit=20
        /// </summary>
        /// <example>https://api.gladia.io/v2/transcription?status=done&amp;offset=20&amp;limit=20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// List of pre-recorded transcriptions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PreRecordedResponse> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPreRecordedResponse" /> class.
        /// </summary>
        /// <param name="first">
        /// URL to fetch the first page<br/>
        /// Example: https://api.gladia.io/v2/transcription?status=done&amp;offset=0&amp;limit=20
        /// </param>
        /// <param name="current">
        /// URL to fetch the current page<br/>
        /// Example: https://api.gladia.io/v2/transcription?status=done&amp;offset=0&amp;limit=20
        /// </param>
        /// <param name="items">
        /// List of pre-recorded transcriptions
        /// </param>
        /// <param name="next">
        /// URL to fetch the next page<br/>
        /// Example: https://api.gladia.io/v2/transcription?status=done&amp;offset=20&amp;limit=20
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListPreRecordedResponse(
            string first,
            string current,
            global::System.Collections.Generic.IList<global::G.PreRecordedResponse> items,
            string? next)
        {
            this.First = first ?? throw new global::System.ArgumentNullException(nameof(first));
            this.Current = current ?? throw new global::System.ArgumentNullException(nameof(current));
            this.Next = next;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPreRecordedResponse" /> class.
        /// </summary>
        public ListPreRecordedResponse()
        {
        }
    }
}