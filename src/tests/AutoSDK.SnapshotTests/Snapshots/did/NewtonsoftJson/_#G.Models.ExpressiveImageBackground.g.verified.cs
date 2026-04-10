//HintName: G.Models.ExpressiveImageBackground.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExpressiveImageBackground
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ExpressiveImageBackgroundTypeJsonConverter))]
        public global::G.ExpressiveImageBackgroundType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ExpressiveImageBackground" /> class.
        /// </summary>
        /// <param name="value">
        /// Example: https://path.to.image/
        /// </param>
        /// <param name="type"></param>
        public ExpressiveImageBackground(
            string value,
            global::G.ExpressiveImageBackgroundType type)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressiveImageBackground" /> class.
        /// </summary>
        public ExpressiveImageBackground()
        {
        }
    }
}