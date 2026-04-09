//HintName: G.Models.PromptDataNullishToolFunctionVariant2Function.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptDataNullishToolFunctionVariant2Function
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PromptDataNullishToolFunctionVariant2FunctionTypeJsonConverter))]
        public global::G.PromptDataNullishToolFunctionVariant2FunctionType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The version of the function
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDataNullishToolFunctionVariant2Function" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="version">
        /// The version of the function
        /// </param>
        public PromptDataNullishToolFunctionVariant2Function(
            string id,
            global::G.PromptDataNullishToolFunctionVariant2FunctionType type,
            string? version)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDataNullishToolFunctionVariant2Function" /> class.
        /// </summary>
        public PromptDataNullishToolFunctionVariant2Function()
        {
        }
    }
}