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
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AccountDetailsV2ResponseImages Images { get; set; }

        /// <summary>
        /// The name of the pricing plan<br/>
        /// Example: basic
        /// </summary>
        /// <example>basic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Plan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsV2Response" /> class.
        /// </summary>
        /// <param name="images"></param>
        /// <param name="plan">
        /// The name of the pricing plan<br/>
        /// Example: basic
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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