//HintName: G.Models.GetExpressiveAvatarsDtoAvatar.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetExpressiveAvatarsDtoAvatar
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AllOf<global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1, object>> Sentiments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExpressiveAvatarsDtoAvatar" /> class.
        /// </summary>
        /// <param name="sentiments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetExpressiveAvatarsDtoAvatar(
            global::System.Collections.Generic.IList<global::G.AllOf<global::G.GetExpressiveAvatarsDtoAvatarSentimentVariant1, object>> sentiments)
        {
            this.Sentiments = sentiments ?? throw new global::System.ArgumentNullException(nameof(sentiments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExpressiveAvatarsDtoAvatar" /> class.
        /// </summary>
        public GetExpressiveAvatarsDtoAvatar()
        {
        }
    }
}