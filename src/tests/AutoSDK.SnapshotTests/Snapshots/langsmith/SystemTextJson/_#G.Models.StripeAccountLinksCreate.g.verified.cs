//HintName: G.Models.StripeAccountLinksCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StripeAccountLinksCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SuccessPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeAccountLinksCreate" /> class.
        /// </summary>
        /// <param name="successPath"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StripeAccountLinksCreate(
            string successPath)
        {
            this.SuccessPath = successPath ?? throw new global::System.ArgumentNullException(nameof(successPath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeAccountLinksCreate" /> class.
        /// </summary>
        public StripeAccountLinksCreate()
        {
        }
    }
}