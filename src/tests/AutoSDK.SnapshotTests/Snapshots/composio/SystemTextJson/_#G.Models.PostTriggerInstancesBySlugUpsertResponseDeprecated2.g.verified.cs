//HintName: G.Models.PostTriggerInstancesBySlugUpsertResponseDeprecated2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostTriggerInstancesBySlugUpsertResponseDeprecated2
    {
        /// <summary>
        /// ID of the updated trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostTriggerInstancesBySlugUpsertResponseDeprecated2" /> class.
        /// </summary>
        /// <param name="uuid">
        /// ID of the updated trigger
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostTriggerInstancesBySlugUpsertResponseDeprecated2(
            string uuid)
        {
            this.Uuid = uuid ?? throw new global::System.ArgumentNullException(nameof(uuid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostTriggerInstancesBySlugUpsertResponseDeprecated2" /> class.
        /// </summary>
        public PostTriggerInstancesBySlugUpsertResponseDeprecated2()
        {
        }
    }
}