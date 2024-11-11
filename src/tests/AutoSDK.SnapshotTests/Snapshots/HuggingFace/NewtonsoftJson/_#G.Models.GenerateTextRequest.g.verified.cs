//HintName: G.Models.GenerateTextRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateTextRequest
    {
        /// <summary>
        /// The prompt that you want to complete.<br/>
        /// Example: This is a test.
        /// </summary>
        /// <example>This is a test.</example>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Inputs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.GenerateTextRequestParameters? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public global::G.GenerateTextRequestOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTextRequest" /> class.
        /// </summary>
        /// <param name="inputs">
        /// The prompt that you want to complete.<br/>
        /// Example: This is a test.
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="options"></param>
        public GenerateTextRequest(
            string? inputs,
            global::G.GenerateTextRequestParameters? parameters,
            global::G.GenerateTextRequestOptions? options)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Parameters = parameters;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTextRequest" /> class.
        /// </summary>
        public GenerateTextRequest()
        {
        }
    }
}