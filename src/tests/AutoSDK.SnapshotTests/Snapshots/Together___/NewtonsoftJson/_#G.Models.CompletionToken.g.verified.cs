//HintName: G.Models.CompletionToken.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionToken
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprob", Required = global::Newtonsoft.Json.Required.Always)]
        public double Logprob { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("special", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Special { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionToken" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="logprob"></param>
        /// <param name="special"></param>
        /// <param name="text"></param>
        public CompletionToken(
            int id,
            double logprob,
            bool special,
            string text)
        {
            this.Id = id;
            this.Logprob = logprob;
            this.Special = special;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionToken" /> class.
        /// </summary>
        public CompletionToken()
        {
        }
    }
}