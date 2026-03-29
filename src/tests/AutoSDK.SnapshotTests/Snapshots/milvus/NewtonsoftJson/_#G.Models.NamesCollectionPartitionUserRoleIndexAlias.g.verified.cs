//HintName: G.Models.NamesCollectionPartitionUserRoleIndexAlias.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NamesCollectionPartitionUserRoleIndexAlias
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public int Code { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamesCollectionPartitionUserRoleIndexAlias" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="data"></param>
        public NamesCollectionPartitionUserRoleIndexAlias(
            int code,
            global::System.Collections.Generic.IList<string> data)
        {
            this.Code = code;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamesCollectionPartitionUserRoleIndexAlias" /> class.
        /// </summary>
        public NamesCollectionPartitionUserRoleIndexAlias()
        {
        }
    }
}