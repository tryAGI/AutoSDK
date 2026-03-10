//HintName: G.Models.Stargazer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Stargazer
    /// </summary>
    public sealed partial class Stargazer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starred_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StarredAt { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.NullableSimpleUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Stargazer" /> class.
        /// </summary>
        /// <param name="starredAt"></param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Stargazer(
            global::System.DateTime starredAt,
            global::G.NullableSimpleUser? user)
        {
            this.StarredAt = starredAt;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stargazer" /> class.
        /// </summary>
        public Stargazer()
        {
        }
    }
}