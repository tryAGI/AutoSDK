//HintName: G.Models.CheckPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public global::G.CheckPublicName? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.CheckPublicResult? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckPublic" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="result"></param>
        public CheckPublic(
            global::G.CheckPublicName? name,
            global::G.CheckPublicResult? result)
        {
            this.Name = name;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckPublic" /> class.
        /// </summary>
        public CheckPublic()
        {
        }
    }
}