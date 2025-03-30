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
        [global::Newtonsoft.Json.JsonProperty("success_path", Required = global::Newtonsoft.Json.Required.Always)]
        public string SuccessPath { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeAccountLinksCreate" /> class.
        /// </summary>
        /// <param name="successPath"></param>
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