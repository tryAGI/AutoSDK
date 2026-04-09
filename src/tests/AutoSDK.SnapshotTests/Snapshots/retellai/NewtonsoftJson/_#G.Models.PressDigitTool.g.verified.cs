//HintName: G.Models.PressDigitTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PressDigitTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PressDigitToolTypeJsonConverter))]
        public global::G.PressDigitToolType Type { get; set; }

        /// <summary>
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state transitions). Must be consisted of a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64 (no space allowed).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Describes what the tool does, sometimes can also include information about when to call the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Delay in milliseconds before pressing the digit, because a lot of IVR systems speak very slowly, and a delay can make sure the agent hears the full menu. Default to 1000 ms (1s). Valid range is 0 to 5000 ms (inclusive).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delay_ms")]
        public int? DelayMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PressDigitTool" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state transitions). Must be consisted of a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64 (no space allowed).
        /// </param>
        /// <param name="type"></param>
        /// <param name="description">
        /// Describes what the tool does, sometimes can also include information about when to call the tool.
        /// </param>
        /// <param name="delayMs">
        /// Delay in milliseconds before pressing the digit, because a lot of IVR systems speak very slowly, and a delay can make sure the agent hears the full menu. Default to 1000 ms (1s). Valid range is 0 to 5000 ms (inclusive).
        /// </param>
        public PressDigitTool(
            string name,
            global::G.PressDigitToolType type,
            string? description,
            int? delayMs)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.DelayMs = delayMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PressDigitTool" /> class.
        /// </summary>
        public PressDigitTool()
        {
        }
    }
}