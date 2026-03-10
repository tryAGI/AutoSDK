//HintName: G.Models.UnitTestToolCallParameter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnitTestToolCallParameter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eval", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Eval Eval { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTestToolCallParameter" /> class.
        /// </summary>
        /// <param name="eval"></param>
        /// <param name="path"></param>
        public UnitTestToolCallParameter(
            global::G.Eval eval,
            string path)
        {
            this.Eval = eval;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTestToolCallParameter" /> class.
        /// </summary>
        public UnitTestToolCallParameter()
        {
        }
    }
}