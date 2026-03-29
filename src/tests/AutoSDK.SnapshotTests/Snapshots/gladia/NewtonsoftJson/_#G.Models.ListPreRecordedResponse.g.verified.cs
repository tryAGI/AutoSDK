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
        [global::Newtonsoft.Json.JsonProperty("first", Required = global::Newtonsoft.Json.Required.Always)]
        public string First { get; set; } = default!;

        /// <summary>
        /// URL to fetch the current page<br/>
        /// Example: https://api.gladia.io/v2/transcription?status=done&amp;offset=0&amp;limit=20
        /// </summary>
        /// <example>https://api.gladia.io/v2/transcription?status=done&amp;offset=0&amp;limit=20</example>
        [global::Newtonsoft.Json.JsonProperty("current", Required = global::Newtonsoft.Json.Required.Always)]
        public string Current { get; set; } = default!;

        /// <summary>
        /// URL to fetch the next page<br/>
        /// Example: https://api.gladia.io/v2/transcription?status=done&amp;offset=20&amp;limit=20
        /// </summary>
        /// <example>https://api.gladia.io/v2/transcription?status=done&amp;offset=20&amp;limit=20</example>
        [global::Newtonsoft.Json.JsonProperty("next")]
        public string? Next { get; set; }

        /// <summary>
        /// List of pre-recorded transcriptions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PreRecordedResponse> Items { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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