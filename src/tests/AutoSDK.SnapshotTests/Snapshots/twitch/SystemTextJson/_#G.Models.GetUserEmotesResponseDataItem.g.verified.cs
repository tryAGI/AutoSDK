//HintName: G.Models.GetUserEmotesResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUserEmotesResponseDataItem
    {
        /// <summary>
        /// An ID that uniquely identifies this emote.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The User ID of broadcaster whose channel is receiving the unban request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The type of emote. The possible values are:   <br/>
        ///   <br/>
        /// * **bitstier** — A Bits tier emote.<br/>
        /// * **follower** — A follower emote.<br/>
        /// * **subscriptions** — A subscriber emote.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emote_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetUserEmotesResponseDataItemEmoteTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetUserEmotesResponseDataItemEmoteType EmoteType { get; set; }

        /// <summary>
        /// An ID that identifies the emote set that the emote belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emote_set_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmoteSetId { get; set; }

        /// <summary>
        /// The ID of the broadcaster who owns the emote.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// The formats that the emote is available in. For example, if the emote is available only as a static PNG, the array contains only static. But if the emote is available as a static PNG and an animated GIF, the array contains static and animated.   <br/>
        ///   <br/>
        /// * **animated** — An animated GIF is available for this emote.<br/>
        /// * **static** — A static PNG file is available for this emote.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Format { get; set; }

        /// <summary>
        /// The sizes that the emote is available in. For example, if the emote is available in small and medium sizes, the array contains 1.0 and 2.0\.   <br/>
        ///   <br/>
        /// * **1.0** — A small version (28px x 28px) is available.<br/>
        /// * **2.0** — A medium version (56px x 56px) is available.<br/>
        /// * **3.0** — A large version (112px x 112px) is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Scale { get; set; }

        /// <summary>
        /// The background themes that the emote is available in.   <br/>
        ///   <br/>
        /// * **dark**<br/>
        /// * **light**
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme_mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ThemeMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserEmotesResponseDataItem" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that uniquely identifies this emote.
        /// </param>
        /// <param name="name">
        /// The User ID of broadcaster whose channel is receiving the unban request.
        /// </param>
        /// <param name="emoteType">
        /// The type of emote. The possible values are:   <br/>
        ///   <br/>
        /// * **bitstier** — A Bits tier emote.<br/>
        /// * **follower** — A follower emote.<br/>
        /// * **subscriptions** — A subscriber emote.
        /// </param>
        /// <param name="emoteSetId">
        /// An ID that identifies the emote set that the emote belongs to.
        /// </param>
        /// <param name="ownerId">
        /// The ID of the broadcaster who owns the emote.
        /// </param>
        /// <param name="format">
        /// The formats that the emote is available in. For example, if the emote is available only as a static PNG, the array contains only static. But if the emote is available as a static PNG and an animated GIF, the array contains static and animated.   <br/>
        ///   <br/>
        /// * **animated** — An animated GIF is available for this emote.<br/>
        /// * **static** — A static PNG file is available for this emote.
        /// </param>
        /// <param name="scale">
        /// The sizes that the emote is available in. For example, if the emote is available in small and medium sizes, the array contains 1.0 and 2.0\.   <br/>
        ///   <br/>
        /// * **1.0** — A small version (28px x 28px) is available.<br/>
        /// * **2.0** — A medium version (56px x 56px) is available.<br/>
        /// * **3.0** — A large version (112px x 112px) is available.
        /// </param>
        /// <param name="themeMode">
        /// The background themes that the emote is available in.   <br/>
        ///   <br/>
        /// * **dark**<br/>
        /// * **light**
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetUserEmotesResponseDataItem(
            string id,
            string name,
            global::G.GetUserEmotesResponseDataItemEmoteType emoteType,
            string emoteSetId,
            string ownerId,
            global::System.Collections.Generic.IList<string> format,
            global::System.Collections.Generic.IList<string> scale,
            global::System.Collections.Generic.IList<string> themeMode)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.EmoteType = emoteType;
            this.EmoteSetId = emoteSetId ?? throw new global::System.ArgumentNullException(nameof(emoteSetId));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Format = format ?? throw new global::System.ArgumentNullException(nameof(format));
            this.Scale = scale ?? throw new global::System.ArgumentNullException(nameof(scale));
            this.ThemeMode = themeMode ?? throw new global::System.ArgumentNullException(nameof(themeMode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserEmotesResponseDataItem" /> class.
        /// </summary>
        public GetUserEmotesResponseDataItem()
        {
        }
    }
}