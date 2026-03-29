//HintName: G.Models.UpsertThreadMessageRequestMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpsertThreadMessageRequestMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("posthogSession")]
        public string? PosthogSession { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertThreadMessageRequestMetadata" /> class.
        /// </summary>
        /// <param name="posthogSession"></param>
        public UpsertThreadMessageRequestMetadata(
            string? posthogSession)
        {
            this.PosthogSession = posthogSession;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertThreadMessageRequestMetadata" /> class.
        /// </summary>
        public UpsertThreadMessageRequestMetadata()
        {
        }
    }
}