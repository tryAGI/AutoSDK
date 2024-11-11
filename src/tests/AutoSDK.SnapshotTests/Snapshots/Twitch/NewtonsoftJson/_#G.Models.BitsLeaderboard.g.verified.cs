//HintName: G.Models.BitsLeaderboard.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BitsLeaderboard
    {
        /// <summary>
        /// An ID that identifies a user on the leaderboard.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The user’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserLogin { get; set; } = default!;

        /// <summary>
        /// The user’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserName { get; set; } = default!;

        /// <summary>
        /// The user’s position on the leaderboard.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rank", Required = global::Newtonsoft.Json.Required.Always)]
        public int Rank { get; set; } = default!;

        /// <summary>
        /// The number of Bits the user has cheered.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public int Score { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BitsLeaderboard" /> class.
        /// </summary>
        /// <param name="userId">
        /// An ID that identifies a user on the leaderboard.
        /// </param>
        /// <param name="userLogin">
        /// The user’s login name.
        /// </param>
        /// <param name="userName">
        /// The user’s display name.
        /// </param>
        /// <param name="rank">
        /// The user’s position on the leaderboard.
        /// </param>
        /// <param name="score">
        /// The number of Bits the user has cheered.
        /// </param>
        public BitsLeaderboard(
            string userId,
            string userLogin,
            string userName,
            int rank,
            int score)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserLogin = userLogin ?? throw new global::System.ArgumentNullException(nameof(userLogin));
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
            this.Rank = rank;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BitsLeaderboard" /> class.
        /// </summary>
        public BitsLeaderboard()
        {
        }
    }
}