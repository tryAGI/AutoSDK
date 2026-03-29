//HintName: G.Models.ListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("consents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ListResponseConsent> Consents { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResponse" /> class.
        /// </summary>
        /// <param name="consents"></param>
        public ListResponse(
            global::System.Collections.Generic.IList<global::G.ListResponseConsent> consents)
        {
            this.Consents = consents ?? throw new global::System.ArgumentNullException(nameof(consents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResponse" /> class.
        /// </summary>
        public ListResponse()
        {
        }
    }
}