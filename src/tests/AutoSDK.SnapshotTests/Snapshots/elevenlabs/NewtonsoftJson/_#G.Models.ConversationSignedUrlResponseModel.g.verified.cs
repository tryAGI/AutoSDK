//HintName: G.Models.ConversationSignedUrlResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationSignedUrlResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signed_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SignedUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSignedUrlResponseModel" /> class.
        /// </summary>
        /// <param name="signedUrl"></param>
        public ConversationSignedUrlResponseModel(
            string signedUrl)
        {
            this.SignedUrl = signedUrl ?? throw new global::System.ArgumentNullException(nameof(signedUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSignedUrlResponseModel" /> class.
        /// </summary>
        public ConversationSignedUrlResponseModel()
        {
        }
    }
}