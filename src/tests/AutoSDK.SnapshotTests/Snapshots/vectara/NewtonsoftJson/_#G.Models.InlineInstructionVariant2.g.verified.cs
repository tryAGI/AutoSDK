//HintName: G.Models.InlineInstructionVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InlineInstructionVariant2
    {
        /// <summary>
        /// The type of instruction, used for discrimination.<br/>
        /// Default Value: inline
        /// </summary>
        /// <default>"inline"</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineInstructionVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of instruction, used for discrimination.<br/>
        /// Default Value: inline
        /// </param>
        public InlineInstructionVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineInstructionVariant2" /> class.
        /// </summary>
        public InlineInstructionVariant2()
        {
        }
    }
}