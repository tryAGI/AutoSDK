//HintName: G.Models.GroundednessCheckRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroundednessCheckRequest
    {
        /// <summary>
        /// The context/source text against which the answer will be verified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context", Required = global::Newtonsoft.Json.Required.Always)]
        public string Context { get; set; } = default!;

        /// <summary>
        /// The answer/response to check for groundedness.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("answer", Required = global::Newtonsoft.Json.Required.Always)]
        public string Answer { get; set; } = default!;

        /// <summary>
        /// The model to use for groundedness check.<br/>
        /// Default: groundedness-check<br/>
        /// Default Value: groundedness-check
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundednessCheckRequest" /> class.
        /// </summary>
        /// <param name="context">
        /// The context/source text against which the answer will be verified.
        /// </param>
        /// <param name="answer">
        /// The answer/response to check for groundedness.
        /// </param>
        /// <param name="model">
        /// The model to use for groundedness check.<br/>
        /// Default: groundedness-check<br/>
        /// Default Value: groundedness-check
        /// </param>
        public GroundednessCheckRequest(
            string context,
            string answer,
            string? model)
        {
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.Answer = answer ?? throw new global::System.ArgumentNullException(nameof(answer));
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundednessCheckRequest" /> class.
        /// </summary>
        public GroundednessCheckRequest()
        {
        }
    }
}