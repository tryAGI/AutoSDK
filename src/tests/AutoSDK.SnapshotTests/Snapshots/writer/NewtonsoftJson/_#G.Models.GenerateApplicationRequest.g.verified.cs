//HintName: G.Models.GenerateApplicationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateApplicationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GenerateApplicationInput> Inputs { get; set; } = default!;

        /// <summary>
        /// Indicates whether the response should be streamed. Currently only supported for research assistant applications.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApplicationRequest" /> class.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="stream">
        /// Indicates whether the response should be streamed. Currently only supported for research assistant applications.
        /// </param>
        public GenerateApplicationRequest(
            global::System.Collections.Generic.IList<global::G.GenerateApplicationInput> inputs,
            bool? stream)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApplicationRequest" /> class.
        /// </summary>
        public GenerateApplicationRequest()
        {
        }
    }
}