//HintName: G.Models.AccountDetailsV2Response.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountDetailsV2Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("images", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AccountDetailsV2ResponseImages Images { get; set; } = default!;

        /// <summary>
        /// The name of the pricing plan<br/>
        /// Example: basic
        /// </summary>
        /// <example>basic</example>
        [global::Newtonsoft.Json.JsonProperty("plan", Required = global::Newtonsoft.Json.Required.Always)]
        public string Plan { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsV2Response" /> class.
        /// </summary>
        /// <param name="images"></param>
        /// <param name="plan">
        /// The name of the pricing plan<br/>
        /// Example: basic
        /// </param>
        public AccountDetailsV2Response(
            global::G.AccountDetailsV2ResponseImages images,
            string plan)
        {
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.Plan = plan ?? throw new global::System.ArgumentNullException(nameof(plan));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsV2Response" /> class.
        /// </summary>
        public AccountDetailsV2Response()
        {
        }
    }
}