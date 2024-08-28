//HintName: G.Models.DetokenizeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetokenizeRequest
    {
        /// <summary>
        /// The list of tokens to be detokenized.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Tokens { get; set; } = default!;

        /// <summary>
        /// An optional parameter to provide the model name. This will ensure that the detokenization is done by the tokenizer used by that model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}