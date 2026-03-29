//HintName: G.Models.PostTriggerInstancesBySlugUpsertResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostTriggerInstancesBySlugUpsertResponse
    {
        /// <summary>
        /// ID of the updated trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TriggerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostTriggerInstancesBySlugUpsertResponseDeprecated Deprecated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostTriggerInstancesBySlugUpsertResponse" /> class.
        /// </summary>
        /// <param name="triggerId">
        /// ID of the updated trigger
        /// </param>
        /// <param name="deprecated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostTriggerInstancesBySlugUpsertResponse(
            string triggerId,
            global::G.PostTriggerInstancesBySlugUpsertResponseDeprecated deprecated)
        {
            this.TriggerId = triggerId ?? throw new global::System.ArgumentNullException(nameof(triggerId));
            this.Deprecated = deprecated ?? throw new global::System.ArgumentNullException(nameof(deprecated));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostTriggerInstancesBySlugUpsertResponse" /> class.
        /// </summary>
        public PostTriggerInstancesBySlugUpsertResponse()
        {
        }
    }
}