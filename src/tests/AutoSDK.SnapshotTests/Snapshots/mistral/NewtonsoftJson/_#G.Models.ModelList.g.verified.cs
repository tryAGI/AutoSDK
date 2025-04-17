//HintName: G.Models.ModelList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.DataItem2>? Data { get; set; }

        /// <summary>
        /// Default Value: list
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelList" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="object">
        /// Default Value: list
        /// </param>
        public ModelList(
            global::System.Collections.Generic.IList<global::G.DataItem2>? data,
            string? @object)
        {
            this.Data = data;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelList" /> class.
        /// </summary>
        public ModelList()
        {
        }
    }
}