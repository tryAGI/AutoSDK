//HintName: G.Models.GetAvatarByIdResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAvatarByIdResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentiments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AllOf<global::G.GetAvatarByIdResponseSentimentVariant1, object>> Sentiments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarByIdResponse2" /> class.
        /// </summary>
        /// <param name="sentiments"></param>
        public GetAvatarByIdResponse2(
            global::System.Collections.Generic.IList<global::G.AllOf<global::G.GetAvatarByIdResponseSentimentVariant1, object>> sentiments)
        {
            this.Sentiments = sentiments ?? throw new global::System.ArgumentNullException(nameof(sentiments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarByIdResponse2" /> class.
        /// </summary>
        public GetAvatarByIdResponse2()
        {
        }
    }
}