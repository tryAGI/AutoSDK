//HintName: G.Models.GetUserEmotesResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUserEmotesResponseData
    {
        /// <summary>
        /// An ID that uniquely identifies this emote.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The User ID of broadcaster whose channel is receiving the unban request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The type of emote. The possible values are:   <br/>
        ///   <br/>
        /// * **bitstier** — A Bits tier emote.<br/>
        /// * **follower** — A follower emote.<br/>
        /// * **subscriptions** — A subscriber emote.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emote_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetUserEmotesResponseDataEmoteType EmoteType { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the emote set that the emote belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emote_set_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EmoteSetId { get; set; } = default!;

        /// <summary>
        /// The ID of the broadcaster who owns the emote.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerId { get; set; } = default!;

        /// <summary>
        /// The formats that the emote is available in. For example, if the emote is available only as a static PNG, the array contains only static. But if the emote is available as a static PNG and an animated GIF, the array contains static and animated.   <br/>
        ///   <br/>
        /// * **animated** — An animated GIF is available for this emote.<br/>
        /// * **static** — A static PNG file is available for this emote.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Format { get; set; } = default!;

        /// <summary>
        /// The sizes that the emote is available in. For example, if the emote is available in small and medium sizes, the array contains 1.0 and 2.0\.   <br/>
        ///   <br/>
        /// * **1.0** — A small version (28px x 28px) is available.<br/>
        /// * **2.0** — A medium version (56px x 56px) is available.<br/>
        /// * **3.0** — A large version (112px x 112px) is available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scale", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Scale { get; set; } = default!;

        /// <summary>
        /// The background themes that the emote is available in.   <br/>
        ///   <br/>
        /// * **dark**<br/>
        /// * **light**
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("theme_mode", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ThemeMode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}