//HintName: G.Models.CreateSavedQueryRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSavedQueryRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sql", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sql { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSavedQueryRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sql"></param>
        public CreateSavedQueryRequest(
            string name,
            string sql)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Sql = sql ?? throw new global::System.ArgumentNullException(nameof(sql));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSavedQueryRequest" /> class.
        /// </summary>
        public CreateSavedQueryRequest()
        {
        }
    }
}