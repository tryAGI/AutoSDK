//HintName: G.Models.AiDetectionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AiDetectionRequest
    {
        /// <summary>
        /// The content to determine if it is AI- or human-generated. Content must have at least 350 characters.<br/>
        /// Example: AI and ML continue to be at the forefront of technological advancements. In 2025, we can expect more sophisticated AI systems that can handle complex tasks with greater efficiency. AI will play a crucial role in various sectors, including healthcare, finance, and manufacturing. For instance, AI-powered diagnostic tools will become more accurate, helping doctors detect diseases at an early stage. In finance, AI algorithms will enhance fraud detection and risk management.
        /// </summary>
        /// <example>AI and ML continue to be at the forefront of technological advancements. In 2025, we can expect more sophisticated AI systems that can handle complex tasks with greater efficiency. AI will play a crucial role in various sectors, including healthcare, finance, and manufacturing. For instance, AI-powered diagnostic tools will become more accurate, helping doctors detect diseases at an early stage. In finance, AI algorithms will enhance fraud detection and risk management.</example>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public string Input { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiDetectionRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// The content to determine if it is AI- or human-generated. Content must have at least 350 characters.<br/>
        /// Example: AI and ML continue to be at the forefront of technological advancements. In 2025, we can expect more sophisticated AI systems that can handle complex tasks with greater efficiency. AI will play a crucial role in various sectors, including healthcare, finance, and manufacturing. For instance, AI-powered diagnostic tools will become more accurate, helping doctors detect diseases at an early stage. In finance, AI algorithms will enhance fraud detection and risk management.
        /// </param>
        public AiDetectionRequest(
            string input)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiDetectionRequest" /> class.
        /// </summary>
        public AiDetectionRequest()
        {
        }
    }
}