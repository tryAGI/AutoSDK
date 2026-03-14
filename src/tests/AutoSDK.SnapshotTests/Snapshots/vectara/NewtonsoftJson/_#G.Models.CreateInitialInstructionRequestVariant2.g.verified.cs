//HintName: G.Models.CreateInitialInstructionRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateInitialInstructionRequestVariant2
    {
        /// <summary>
        /// The type of instruction to create.<br/>
        /// Default Value: initial<br/>
        /// Example: initial
        /// </summary>
        /// <default>"initial"</default>
        /// <example>initial</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInitialInstructionRequestVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of instruction to create.<br/>
        /// Default Value: initial<br/>
        /// Example: initial
        /// </param>
        public CreateInitialInstructionRequestVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInitialInstructionRequestVariant2" /> class.
        /// </summary>
        public CreateInitialInstructionRequestVariant2()
        {
        }
    }
}