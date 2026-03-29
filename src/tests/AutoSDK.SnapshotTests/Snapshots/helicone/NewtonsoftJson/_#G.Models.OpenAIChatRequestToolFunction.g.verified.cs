//HintName: G.Models.OpenAIChatRequestToolFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIChatRequestToolFunction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.RecordStringAny? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatRequestToolFunction" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="strict"></param>
        /// <param name="parameters">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="description"></param>
        public OpenAIChatRequestToolFunction(
            string name,
            bool? strict,
            global::G.RecordStringAny? parameters,
            string? description)
        {
            this.Strict = strict;
            this.Parameters = parameters;
            this.Description = description;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatRequestToolFunction" /> class.
        /// </summary>
        public OpenAIChatRequestToolFunction()
        {
        }
    }
}