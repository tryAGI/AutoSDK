//HintName: G.Models.CreateInputRequestBase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base properties shared by all input request types.
    /// </summary>
    public sealed partial class CreateInputRequestBase
    {
        /// <summary>
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream_response")]
        public bool? StreamResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInputRequestBase" /> class.
        /// </summary>
        /// <param name="streamResponse">
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </param>
        public CreateInputRequestBase(
            bool? streamResponse)
        {
            this.StreamResponse = streamResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInputRequestBase" /> class.
        /// </summary>
        public CreateInputRequestBase()
        {
        }
    }
}