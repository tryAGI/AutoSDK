//HintName: G.Models.GenerateApplicationAsyncRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateApplicationAsyncRequest
    {
        /// <summary>
        /// A list of input objects to generate content for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GenerateApplicationInput> Inputs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApplicationAsyncRequest" /> class.
        /// </summary>
        /// <param name="inputs">
        /// A list of input objects to generate content for.
        /// </param>
        public GenerateApplicationAsyncRequest(
            global::System.Collections.Generic.IList<global::G.GenerateApplicationInput> inputs)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApplicationAsyncRequest" /> class.
        /// </summary>
        public GenerateApplicationAsyncRequest()
        {
        }
    }
}