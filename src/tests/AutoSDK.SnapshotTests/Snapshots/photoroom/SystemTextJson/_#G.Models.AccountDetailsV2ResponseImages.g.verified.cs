//HintName: G.Models.AccountDetailsV2ResponseImages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountDetailsV2ResponseImages
    {
        /// <summary>
        /// The number of images available<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Available { get; set; }

        /// <summary>
        /// The total number of image available in the subscription<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsV2ResponseImages" /> class.
        /// </summary>
        /// <param name="available">
        /// The number of images available<br/>
        /// Example: 100
        /// </param>
        /// <param name="subscription">
        /// The total number of image available in the subscription<br/>
        /// Example: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountDetailsV2ResponseImages(
            double available,
            double subscription)
        {
            this.Available = available;
            this.Subscription = subscription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsV2ResponseImages" /> class.
        /// </summary>
        public AccountDetailsV2ResponseImages()
        {
        }
    }
}