//HintName: G.Models.CreateExpressiveRequestDtoBackgroundVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExpressiveRequestDtoBackgroundVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateExpressiveRequestDtoBackgroundVariant2Type Type { get; set; }

        /// <summary>
        /// Example: https://path.to.image/
        /// </summary>
        /// <example>https://path.to.image/</example>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressiveRequestDtoBackgroundVariant2" /> class.
        /// </summary>
        /// <param name="value">
        /// Example: https://path.to.image/
        /// </param>
        /// <param name="type"></param>
        public CreateExpressiveRequestDtoBackgroundVariant2(
            string value,
            global::G.CreateExpressiveRequestDtoBackgroundVariant2Type type)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressiveRequestDtoBackgroundVariant2" /> class.
        /// </summary>
        public CreateExpressiveRequestDtoBackgroundVariant2()
        {
        }
    }
}