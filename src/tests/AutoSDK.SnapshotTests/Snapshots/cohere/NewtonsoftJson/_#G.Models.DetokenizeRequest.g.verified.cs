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
        /// The list of tokens to be detokenized.<br/>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokens")]
        public global::System.Collections.Generic.IList<int>? Tokens { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="DetokenizeRequest" /> class.
        /// </summary>
        /// <param name="tokens">
        /// The list of tokens to be detokenized.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="model">
        /// An optional parameter to provide the model name. This will ensure that the detokenization is done by the tokenizer used by that model.
        /// </param>
        public DetokenizeRequest(
            string model,
            global::System.Collections.Generic.IList<int>? tokens)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Tokens = tokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetokenizeRequest" /> class.
        /// </summary>
        public DetokenizeRequest()
        {
        }
    }
}