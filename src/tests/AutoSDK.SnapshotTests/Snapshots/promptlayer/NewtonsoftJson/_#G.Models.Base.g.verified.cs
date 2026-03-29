//HintName: G.Models.Base.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Base
    {
        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Default Value: 30
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("per_page")]
        public int? PerPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Base" /> class.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        public Base(
            int? page,
            int? perPage)
        {
            this.Page = page;
            this.PerPage = perPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Base" /> class.
        /// </summary>
        public Base()
        {
        }
    }
}