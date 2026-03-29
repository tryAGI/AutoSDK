//HintName: G.Models.InterruptFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InterruptFunction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InterruptFunction" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="name"></param>
        public InterruptFunction(
            string? arguments,
            string? name)
        {
            this.Arguments = arguments;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InterruptFunction" /> class.
        /// </summary>
        public InterruptFunction()
        {
        }
    }
}