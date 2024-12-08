//HintName: G.Models.BetaRequestToolUseBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestToolUseBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.BetaCacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaRequestToolUseBlockType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public object Input { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestToolUseBlock" /> class.
        /// </summary>
        /// <param name="cacheControl"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="input"></param>
        public BetaRequestToolUseBlock(
            string id,
            string name,
            object input,
            global::G.BetaCacheControlEphemeral? cacheControl,
            global::G.BetaRequestToolUseBlockType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.CacheControl = cacheControl;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestToolUseBlock" /> class.
        /// </summary>
        public BetaRequestToolUseBlock()
        {
        }
    }
}