//HintName: G.Models.InvalidToolCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Allowance for errors made by LLM.<br/>
    /// Here we add an `error` key to surface errors made during generation<br/>
    /// (e.g., invalid JSON arguments.)
    /// </summary>
    public sealed partial class InvalidToolCall
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("args", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Args { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Error { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidToolCall" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="args"></param>
        /// <param name="id"></param>
        /// <param name="error"></param>
        /// <param name="type"></param>
        public InvalidToolCall(
            string? name,
            string? args,
            string? id,
            string? error,
            string? type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidToolCall" /> class.
        /// </summary>
        public InvalidToolCall()
        {
        }
    }
}