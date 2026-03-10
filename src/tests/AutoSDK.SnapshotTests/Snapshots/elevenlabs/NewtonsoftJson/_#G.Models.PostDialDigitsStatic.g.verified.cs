//HintName: G.Models.PostDialDigitsStatic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostDialDigitsStatic
    {
        /// <summary>
        /// Default Value: static
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// DTMF digits to send after call connects (e.g., 'ww1234' for extension)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDialDigitsStatic" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: static
        /// </param>
        /// <param name="value">
        /// DTMF digits to send after call connects (e.g., 'ww1234' for extension)
        /// </param>
        public PostDialDigitsStatic(
            string value,
            string? type)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDialDigitsStatic" /> class.
        /// </summary>
        public PostDialDigitsStatic()
        {
        }
    }
}