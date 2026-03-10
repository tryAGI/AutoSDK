//HintName: G.Models.Missing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Missing
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"__missing__"</default>
        [global::Newtonsoft.Json.JsonProperty("__missing__")]
        public string Missing1 { get; set; } = "__missing__";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Missing" /> class.
        /// </summary>
        /// <param name="missing1"></param>
        public Missing(
            string missing1 = "__missing__")
        {
            this.Missing1 = missing1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Missing" /> class.
        /// </summary>
        public Missing()
        {
        }
    }
}