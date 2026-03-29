//HintName: G.Models.CreateExpressiveRequestDtoBackgroundVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExpressiveRequestDtoBackgroundVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateExpressiveRequestDtoBackgroundVariant1Type Type { get; set; }

        /// <summary>
        /// Example: #47ffff
        /// </summary>
        /// <example>#47ffff</example>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressiveRequestDtoBackgroundVariant1" /> class.
        /// </summary>
        /// <param name="value">
        /// Example: #47ffff
        /// </param>
        /// <param name="type"></param>
        public CreateExpressiveRequestDtoBackgroundVariant1(
            string value,
            global::G.CreateExpressiveRequestDtoBackgroundVariant1Type type)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressiveRequestDtoBackgroundVariant1" /> class.
        /// </summary>
        public CreateExpressiveRequestDtoBackgroundVariant1()
        {
        }
    }
}