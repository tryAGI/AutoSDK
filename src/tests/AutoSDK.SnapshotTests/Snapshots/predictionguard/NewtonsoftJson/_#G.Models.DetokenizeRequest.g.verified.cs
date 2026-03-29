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
        /// The name of the model to use for detokenization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The tokens to turn into text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Tokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetokenizeRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The name of the model to use for detokenization.
        /// </param>
        /// <param name="tokens">
        /// The tokens to turn into text.
        /// </param>
        public DetokenizeRequest(
            string model,
            global::System.Collections.Generic.IList<int> tokens)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Tokens = tokens ?? throw new global::System.ArgumentNullException(nameof(tokens));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetokenizeRequest" /> class.
        /// </summary>
        public DetokenizeRequest()
        {
        }
    }
}