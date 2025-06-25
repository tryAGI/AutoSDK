﻿//HintName: G.Models.BanUserBodyData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identifies the user and type of ban.
    /// </summary>
    public sealed partial class BanUserBodyData
    {
        /// <summary>
        /// The ID of the user to ban or put in a timeout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// To ban a user indefinitely, don’t include this field.  <br/>
        ///   <br/>
        /// To put a user in a timeout, include this field and specify the timeout period, in seconds. The minimum timeout is 1 second and the maximum is 1,209,600 seconds (2 weeks).  <br/>
        ///   <br/>
        /// To end a user’s timeout early, set this field to 1, or use the [Unban user](https://dev.twitch.tv/docs/api/reference#unban-user) endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// The reason the you’re banning the user or putting them in a timeout. The text is user defined and is limited to a maximum of 500 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BanUserBodyData" /> class.
        /// </summary>
        /// <param name="userId">
        /// The ID of the user to ban or put in a timeout.
        /// </param>
        /// <param name="duration">
        /// To ban a user indefinitely, don’t include this field.  <br/>
        ///   <br/>
        /// To put a user in a timeout, include this field and specify the timeout period, in seconds. The minimum timeout is 1 second and the maximum is 1,209,600 seconds (2 weeks).  <br/>
        ///   <br/>
        /// To end a user’s timeout early, set this field to 1, or use the [Unban user](https://dev.twitch.tv/docs/api/reference#unban-user) endpoint.
        /// </param>
        /// <param name="reason">
        /// The reason the you’re banning the user or putting them in a timeout. The text is user defined and is limited to a maximum of 500 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BanUserBodyData(
            string userId,
            int? duration,
            string? reason)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Duration = duration;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BanUserBodyData" /> class.
        /// </summary>
        public BanUserBodyData()
        {
        }
    }
}