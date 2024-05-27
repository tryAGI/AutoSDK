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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the category. For example, the game’s title if the broadcaster will play a game or Just Chatting if the broadcaster will host a talk show.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}