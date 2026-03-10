//HintName: G.Models.ListWhatsAppAccountsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListWhatsAppAccountsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetWhatsAppAccountResponse> Items { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWhatsAppAccountsResponse" /> class.
        /// </summary>
        /// <param name="items"></param>
        public ListWhatsAppAccountsResponse(
            global::System.Collections.Generic.IList<global::G.GetWhatsAppAccountResponse> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWhatsAppAccountsResponse" /> class.
        /// </summary>
        public ListWhatsAppAccountsResponse()
        {
        }
    }
}