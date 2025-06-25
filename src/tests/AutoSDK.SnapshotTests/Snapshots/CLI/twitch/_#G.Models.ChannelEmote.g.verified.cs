﻿//HintName: G.Models.ChannelEmote.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChannelEmote
    {
        /// <summary>
        /// An ID that identifies this emote.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the emote. This is the name that viewers type in the chat window to get the emote to appear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The image URLs for the emote. These image URLs always provide a static, non-animated emote image with a light background.  <br/>
        ///   <br/>
        /// **NOTE:** You should use the templated URL in the `template` field to fetch the image instead of using these URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChannelEmoteImages Images { get; set; }

        /// <summary>
        /// The subscriber tier at which the emote is unlocked. This field contains the tier information only if `emote_type` is set to `subscriptions`, otherwise, it's an empty string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tier { get; set; }

        /// <summary>
        /// The type of emote. The possible values are:  <br/>
        ///   <br/>
        /// * bitstier — A custom Bits tier emote.<br/>
        /// * follower — A custom follower emote.<br/>
        /// * subscriptions — A custom subscriber emote.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emote_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChannelEmoteEmoteTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChannelEmoteEmoteType EmoteType { get; set; }

        /// <summary>
        /// An ID that identifies the emote set that the emote belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emote_set_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmoteSetId { get; set; }

        /// <summary>
        /// The formats that the emote is available in. For example, if the emote is available only as a static PNG, the array contains only `static`. But if the emote is available as a static PNG and an animated GIF, the array contains `static` and `animated`. The possible formats are:  <br/>
        ///   <br/>
        /// * animated — An animated GIF is available for this emote.<br/>
        /// * static — A static PNG file is available for this emote.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChannelEmoteFormatItem> Format { get; set; }

        /// <summary>
        /// The sizes that the emote is available in. For example, if the emote is available in small and medium sizes, the array contains 1.0 and 2.0\. Possible sizes are:  <br/>
        ///   <br/>
        /// * 1.0 — A small version (28px x 28px) is available.<br/>
        /// * 2.0 — A medium version (56px x 56px) is available.<br/>
        /// * 3.0 — A large version (112px x 112px) is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChannelEmoteScaleItem> Scale { get; set; }

        /// <summary>
        /// The background themes that the emote is available in. Possible themes are:  <br/>
        ///   <br/>
        /// * dark<br/>
        /// * light
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme_mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChannelEmoteThemeModeItem> ThemeMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelEmote" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that identifies this emote.
        /// </param>
        /// <param name="name">
        /// The name of the emote. This is the name that viewers type in the chat window to get the emote to appear.
        /// </param>
        /// <param name="images">
        /// The image URLs for the emote. These image URLs always provide a static, non-animated emote image with a light background.  <br/>
        ///   <br/>
        /// **NOTE:** You should use the templated URL in the `template` field to fetch the image instead of using these URLs.
        /// </param>
        /// <param name="tier">
        /// The subscriber tier at which the emote is unlocked. This field contains the tier information only if `emote_type` is set to `subscriptions`, otherwise, it's an empty string.
        /// </param>
        /// <param name="emoteType">
        /// The type of emote. The possible values are:  <br/>
        ///   <br/>
        /// * bitstier — A custom Bits tier emote.<br/>
        /// * follower — A custom follower emote.<br/>
        /// * subscriptions — A custom subscriber emote.
        /// </param>
        /// <param name="emoteSetId">
        /// An ID that identifies the emote set that the emote belongs to.
        /// </param>
        /// <param name="format">
        /// The formats that the emote is available in. For example, if the emote is available only as a static PNG, the array contains only `static`. But if the emote is available as a static PNG and an animated GIF, the array contains `static` and `animated`. The possible formats are:  <br/>
        ///   <br/>
        /// * animated — An animated GIF is available for this emote.<br/>
        /// * static — A static PNG file is available for this emote.
        /// </param>
        /// <param name="scale">
        /// The sizes that the emote is available in. For example, if the emote is available in small and medium sizes, the array contains 1.0 and 2.0\. Possible sizes are:  <br/>
        ///   <br/>
        /// * 1.0 — A small version (28px x 28px) is available.<br/>
        /// * 2.0 — A medium version (56px x 56px) is available.<br/>
        /// * 3.0 — A large version (112px x 112px) is available.
        /// </param>
        /// <param name="themeMode">
        /// The background themes that the emote is available in. Possible themes are:  <br/>
        ///   <br/>
        /// * dark<br/>
        /// * light
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelEmote(
            string id,
            string name,
            global::G.ChannelEmoteImages images,
            string tier,
            global::G.ChannelEmoteEmoteType emoteType,
            string emoteSetId,
            global::System.Collections.Generic.IList<global::G.ChannelEmoteFormatItem> format,
            global::System.Collections.Generic.IList<global::G.ChannelEmoteScaleItem> scale,
            global::System.Collections.Generic.IList<global::G.ChannelEmoteThemeModeItem> themeMode)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.Tier = tier ?? throw new global::System.ArgumentNullException(nameof(tier));
            this.EmoteType = emoteType;
            this.EmoteSetId = emoteSetId ?? throw new global::System.ArgumentNullException(nameof(emoteSetId));
            this.Format = format ?? throw new global::System.ArgumentNullException(nameof(format));
            this.Scale = scale ?? throw new global::System.ArgumentNullException(nameof(scale));
            this.ThemeMode = themeMode ?? throw new global::System.ArgumentNullException(nameof(themeMode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelEmote" /> class.
        /// </summary>
        public ChannelEmote()
        {
        }
    }
}