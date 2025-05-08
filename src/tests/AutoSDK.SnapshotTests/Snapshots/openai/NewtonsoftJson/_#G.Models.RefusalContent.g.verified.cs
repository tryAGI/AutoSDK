//HintName: G.Models.RefusalContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A refusal from the model.
    /// </summary>
    public sealed partial class RefusalContent
    {
        /// <summary>
        /// The type of the refusal. Always `refusal`.<br/>
        /// Default Value: refusal
        /// </summary>
        /// <default>global::G.RefusalContentType.Refusal</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RefusalContentType Type { get; set; } = global::G.RefusalContentType.Refusal;

        /// <summary>
        /// The refusal explanationfrom the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refusal", Required = global::Newtonsoft.Json.Required.Always)]
        public string Refusal { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RefusalContent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the refusal. Always `refusal`.<br/>
        /// Default Value: refusal
        /// </param>
        /// <param name="refusal">
        /// The refusal explanationfrom the model.
        /// </param>
        public RefusalContent(
            string refusal,
            global::G.RefusalContentType type = global::G.RefusalContentType.Refusal)
        {
            this.Refusal = refusal ?? throw new global::System.ArgumentNullException(nameof(refusal));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefusalContent" /> class.
        /// </summary>
        public RefusalContent()
        {
        }
    }
}