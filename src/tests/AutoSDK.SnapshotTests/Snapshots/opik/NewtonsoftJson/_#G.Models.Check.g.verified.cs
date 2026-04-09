//HintName: G.Models.Check.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Check
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CheckNameJsonConverter))]
        public global::G.CheckName? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CheckResultJsonConverter))]
        public global::G.CheckResult? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Check" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="result"></param>
        public Check(
            global::G.CheckName? name,
            global::G.CheckResult? result)
        {
            this.Name = name;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Check" /> class.
        /// </summary>
        public Check()
        {
        }
    }
}