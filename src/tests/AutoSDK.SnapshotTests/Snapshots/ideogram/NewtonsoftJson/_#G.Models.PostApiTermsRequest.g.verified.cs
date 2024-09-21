//HintName: G.Models.PostApiTermsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostApiTermsRequest
    {
        /// <summary>
        /// The ID of the terms which are being accepted.<br/>
        /// Example: TOS_2024_04_20
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("terms_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TermsId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}