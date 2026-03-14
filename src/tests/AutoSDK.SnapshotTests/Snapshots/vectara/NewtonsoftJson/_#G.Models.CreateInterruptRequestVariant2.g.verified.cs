//HintName: G.Models.CreateInterruptRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateInterruptRequestVariant2
    {
        /// <summary>
        /// Default Value: interrupt
        /// </summary>
        /// <default>"interrupt"</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInterruptRequestVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: interrupt
        /// </param>
        public CreateInterruptRequestVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInterruptRequestVariant2" /> class.
        /// </summary>
        public CreateInterruptRequestVariant2()
        {
        }
    }
}