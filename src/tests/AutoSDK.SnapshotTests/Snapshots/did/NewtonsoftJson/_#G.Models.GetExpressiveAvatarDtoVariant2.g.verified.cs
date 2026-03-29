//HintName: G.Models.GetExpressiveAvatarDtoVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetExpressiveAvatarDtoVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentiments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AllOf<global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1, object>> Sentiments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExpressiveAvatarDtoVariant2" /> class.
        /// </summary>
        /// <param name="sentiments"></param>
        public GetExpressiveAvatarDtoVariant2(
            global::System.Collections.Generic.IList<global::G.AllOf<global::G.GetExpressiveAvatarDtoVariant2SentimentVariant1, object>> sentiments)
        {
            this.Sentiments = sentiments ?? throw new global::System.ArgumentNullException(nameof(sentiments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExpressiveAvatarDtoVariant2" /> class.
        /// </summary>
        public GetExpressiveAvatarDtoVariant2()
        {
        }
    }
}