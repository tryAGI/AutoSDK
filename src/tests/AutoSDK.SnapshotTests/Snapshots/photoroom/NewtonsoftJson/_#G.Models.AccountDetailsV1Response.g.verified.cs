//HintName: G.Models.AccountDetailsV1Response.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountDetailsV1Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AccountDetailsV1ResponseCredits Credits { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsV1Response" /> class.
        /// </summary>
        /// <param name="credits"></param>
        public AccountDetailsV1Response(
            global::G.AccountDetailsV1ResponseCredits credits)
        {
            this.Credits = credits ?? throw new global::System.ArgumentNullException(nameof(credits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsV1Response" /> class.
        /// </summary>
        public AccountDetailsV1Response()
        {
        }
    }
}