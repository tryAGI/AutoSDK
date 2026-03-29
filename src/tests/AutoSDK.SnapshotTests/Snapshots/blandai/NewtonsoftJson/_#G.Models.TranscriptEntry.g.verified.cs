//HintName: G.Models.TranscriptEntry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Speaker identifier (e.g. "agent", "user")
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptEntry" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="text"></param>
        /// <param name="user">
        /// Speaker identifier (e.g. "agent", "user")
        /// </param>
        public TranscriptEntry(
            int? id,
            global::System.DateTime? createdAt,
            string? text,
            string? user)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Text = text;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptEntry" /> class.
        /// </summary>
        public TranscriptEntry()
        {
        }
    }
}