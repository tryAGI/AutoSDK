//HintName: G.Models.ResultsNumberPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultsNumberPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.DataPointNumberPublic>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultsNumberPublic" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="data"></param>
        public ResultsNumberPublic(
            string? name,
            global::System.Collections.Generic.IList<global::G.DataPointNumberPublic>? data)
        {
            this.Name = name;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultsNumberPublic" /> class.
        /// </summary>
        public ResultsNumberPublic()
        {
        }
    }
}