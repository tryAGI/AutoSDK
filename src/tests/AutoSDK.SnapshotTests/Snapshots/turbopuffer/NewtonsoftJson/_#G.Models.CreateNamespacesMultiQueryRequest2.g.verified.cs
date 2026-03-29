//HintName: G.Models.CreateNamespacesMultiQueryRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateNamespacesMultiQueryRequest2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queries", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Query> Queries { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespacesMultiQueryRequest2" /> class.
        /// </summary>
        /// <param name="queries"></param>
        public CreateNamespacesMultiQueryRequest2(
            global::System.Collections.Generic.IList<global::G.Query> queries)
        {
            this.Queries = queries ?? throw new global::System.ArgumentNullException(nameof(queries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespacesMultiQueryRequest2" /> class.
        /// </summary>
        public CreateNamespacesMultiQueryRequest2()
        {
        }
    }
}