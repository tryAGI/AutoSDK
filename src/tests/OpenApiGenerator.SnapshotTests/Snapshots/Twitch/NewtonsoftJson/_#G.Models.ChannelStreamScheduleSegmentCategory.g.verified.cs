//HintName: G.Models.ChannelStreamScheduleSegmentCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of content that the broadcaster plans to stream or **null** if not specified.
    /// </summary>
    public sealed partial class ChannelStreamScheduleSegmentCategory
    {
        /// <summary>
        /// An ID that identifies the category that best represents the content that the broadcaster plans to stream. For example, the game’s ID if the broadcaster will play a game or the Just Chatting ID if the broadcaster will host a talk show.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The name of the category. For example, the game’s title if the broadcaster will play a game or Just Chatting if the broadcaster will host a talk show.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}