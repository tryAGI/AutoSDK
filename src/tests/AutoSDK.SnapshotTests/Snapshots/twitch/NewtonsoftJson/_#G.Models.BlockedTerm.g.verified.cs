﻿//HintName: G.Models.BlockedTerm.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BlockedTerm
    {
        /// <summary>
        /// The broadcaster that owns the list of blocked terms.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// The moderator that blocked the word or phrase from being used in the broadcaster’s chat room.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moderator_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModeratorId { get; set; } = default!;

        /// <summary>
        /// An ID that identifies this blocked term.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The blocked word or phrase.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) that the term was blocked.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) that the term was updated.  <br/>
        ///   <br/>
        /// When the term is added, this timestamp is the same as `created_at`. The timestamp changes as AutoMod continues to deny the term.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) that the blocked term is set to expire. After the block expires, users may use the term in the broadcaster’s chat room.  <br/>
        ///   <br/>
        /// This field is **null** if the term was added manually or was permanently blocked by AutoMod.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? ExpiresAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockedTerm" /> class.
        /// </summary>
        /// <param name="broadcasterId">
        /// The broadcaster that owns the list of blocked terms.
        /// </param>
        /// <param name="moderatorId">
        /// The moderator that blocked the word or phrase from being used in the broadcaster’s chat room.
        /// </param>
        /// <param name="id">
        /// An ID that identifies this blocked term.
        /// </param>
        /// <param name="text">
        /// The blocked word or phrase.
        /// </param>
        /// <param name="createdAt">
        /// The UTC date and time (in RFC3339 format) that the term was blocked.
        /// </param>
        /// <param name="updatedAt">
        /// The UTC date and time (in RFC3339 format) that the term was updated.  <br/>
        ///   <br/>
        /// When the term is added, this timestamp is the same as `created_at`. The timestamp changes as AutoMod continues to deny the term.
        /// </param>
        /// <param name="expiresAt">
        /// The UTC date and time (in RFC3339 format) that the blocked term is set to expire. After the block expires, users may use the term in the broadcaster’s chat room.  <br/>
        ///   <br/>
        /// This field is **null** if the term was added manually or was permanently blocked by AutoMod.
        /// </param>
        public BlockedTerm(
            string broadcasterId,
            string moderatorId,
            string id,
            string text,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime? expiresAt)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.ModeratorId = moderatorId ?? throw new global::System.ArgumentNullException(nameof(moderatorId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockedTerm" /> class.
        /// </summary>
        public BlockedTerm()
        {
        }
    }
}