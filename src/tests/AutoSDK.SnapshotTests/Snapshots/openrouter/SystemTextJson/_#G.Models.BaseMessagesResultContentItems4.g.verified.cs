//HintName: G.Models.BaseMessagesResultContentItems4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItems4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf4TypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf4Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caller")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf4CallerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BaseMessagesResultContentItemsOneOf4Caller Caller { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf4NameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BaseMessagesResultContentItemsOneOf4Name Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItems4" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="caller"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="input"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseMessagesResultContentItems4(
            string id,
            global::G.BaseMessagesResultContentItemsOneOf4Caller caller,
            global::G.BaseMessagesResultContentItemsOneOf4Name name,
            global::G.BaseMessagesResultContentItemsOneOf4Type type,
            object? input)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Caller = caller;
            this.Name = name;
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItems4" /> class.
        /// </summary>
        public BaseMessagesResultContentItems4()
        {
        }
    }
}