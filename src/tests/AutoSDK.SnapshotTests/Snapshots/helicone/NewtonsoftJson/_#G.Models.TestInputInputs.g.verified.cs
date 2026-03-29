//HintName: G.Models.TestInputInputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestInputInputs
    {
        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoInputs")]
        public global::System.Collections.Generic.Dictionary<string, string>? AutoInputs { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Inputs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestInputInputs" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="autoInputs">
        /// Construct a type with a set of properties K of type T
        /// </param>
        public TestInputInputs(
            global::System.Collections.Generic.Dictionary<string, string> inputs,
            global::System.Collections.Generic.Dictionary<string, string>? autoInputs)
        {
            this.AutoInputs = autoInputs;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestInputInputs" /> class.
        /// </summary>
        public TestInputInputs()
        {
        }
    }
}