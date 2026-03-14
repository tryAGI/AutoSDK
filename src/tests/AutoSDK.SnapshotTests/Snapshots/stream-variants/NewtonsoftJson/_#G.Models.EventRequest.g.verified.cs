//HintName: G.Models.EventRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EventRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public string Input { get; set; } = default!;

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventRequest" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="stream">
        /// Default Value: true
        /// </param>
        public EventRequest(
            string input,
            bool? stream)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventRequest" /> class.
        /// </summary>
        public EventRequest()
        {
        }
    }
}