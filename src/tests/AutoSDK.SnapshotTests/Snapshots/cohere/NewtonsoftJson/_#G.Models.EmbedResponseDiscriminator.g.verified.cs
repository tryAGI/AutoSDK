//HintName: G.Models.EmbedResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_type")]
        public global::G.EmbedResponseDiscriminatorResponseType? ResponseType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="responseType"></param>
        public EmbedResponseDiscriminator(
            global::G.EmbedResponseDiscriminatorResponseType? responseType)
        {
            this.ResponseType = responseType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedResponseDiscriminator" /> class.
        /// </summary>
        public EmbedResponseDiscriminator()
        {
        }
    }
}