//HintName: G.Models.PostTriggerInstancesBySlugUpsertResponseDeprecated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostTriggerInstancesBySlugUpsertResponseDeprecated
    {
        /// <summary>
        /// ID of the updated trigger
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uuid", Required = global::Newtonsoft.Json.Required.Always)]
        public string Uuid { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostTriggerInstancesBySlugUpsertResponseDeprecated" /> class.
        /// </summary>
        /// <param name="uuid">
        /// ID of the updated trigger
        /// </param>
        public PostTriggerInstancesBySlugUpsertResponseDeprecated(
            string uuid)
        {
            this.Uuid = uuid ?? throw new global::System.ArgumentNullException(nameof(uuid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostTriggerInstancesBySlugUpsertResponseDeprecated" /> class.
        /// </summary>
        public PostTriggerInstancesBySlugUpsertResponseDeprecated()
        {
        }
    }
}