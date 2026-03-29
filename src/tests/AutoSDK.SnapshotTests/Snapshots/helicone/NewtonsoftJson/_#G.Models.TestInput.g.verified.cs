//HintName: G.Models.TestInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptTemplate")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TestInputInputs Inputs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputBody", Required = global::Newtonsoft.Json.Required.Always)]
        public string OutputBody { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputBody", Required = global::Newtonsoft.Json.Required.Always)]
        public string InputBody { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestInput" /> class.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="outputBody"></param>
        /// <param name="inputBody"></param>
        /// <param name="promptTemplate"></param>
        public TestInput(
            global::G.TestInputInputs inputs,
            string outputBody,
            string inputBody,
            string? promptTemplate)
        {
            this.PromptTemplate = promptTemplate;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.OutputBody = outputBody ?? throw new global::System.ArgumentNullException(nameof(outputBody));
            this.InputBody = inputBody ?? throw new global::System.ArgumentNullException(nameof(inputBody));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestInput" /> class.
        /// </summary>
        public TestInput()
        {
        }
    }
}