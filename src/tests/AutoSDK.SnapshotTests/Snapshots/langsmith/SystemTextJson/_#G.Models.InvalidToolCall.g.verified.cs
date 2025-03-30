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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Args { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InvalidToolCallTypeJsonConverter))]
        public global::G.InvalidToolCallType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidToolCall" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="args"></param>
        /// <param name="id"></param>
        /// <param name="error"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InvalidToolCall(
            string? name,
            string? args,
            string? id,
            string? error,
            global::G.InvalidToolCallType? type)
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