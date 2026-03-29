//HintName: G.Models.Schema3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema representation for collection index configurations<br/>
    /// This represents the server-side schema structure used for index management
    /// </summary>
    public sealed partial class Schema3
    {
        /// <summary>
        /// Customer-managed encryption key for collection data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cmek")]
        public object? Cmek { get; set; }

        /// <summary>
        /// Default index configurations for each value type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("defaults", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ValueTypes Defaults { get; set; } = default!;

        /// <summary>
        /// Key-specific index overrides<br/>
        /// TODO(Sanket): Needed for backwards compatibility. Should remove after deploy.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keys", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.ValueTypes> Keys { get; set; } = default!;

        /// <summary>
        /// ID of the attached function that created this output collection (if applicable)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_attached_function_id")]
        public string? SourceAttachedFunctionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Schema3" /> class.
        /// </summary>
        /// <param name="defaults">
        /// Default index configurations for each value type
        /// </param>
        /// <param name="keys">
        /// Key-specific index overrides<br/>
        /// TODO(Sanket): Needed for backwards compatibility. Should remove after deploy.
        /// </param>
        /// <param name="cmek">
        /// Customer-managed encryption key for collection data
        /// </param>
        /// <param name="sourceAttachedFunctionId">
        /// ID of the attached function that created this output collection (if applicable)
        /// </param>
        public Schema3(
            global::G.ValueTypes defaults,
            global::System.Collections.Generic.Dictionary<string, global::G.ValueTypes> keys,
            object? cmek,
            string? sourceAttachedFunctionId)
        {
            this.Cmek = cmek;
            this.Defaults = defaults ?? throw new global::System.ArgumentNullException(nameof(defaults));
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
            this.SourceAttachedFunctionId = sourceAttachedFunctionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Schema3" /> class.
        /// </summary>
        public Schema3()
        {
        }
    }
}