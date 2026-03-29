//HintName: G.Models.CostCreateRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CostCreateRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<byte[]> Ids { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostCreateRes" /> class.
        /// </summary>
        /// <param name="ids"></param>
        public CostCreateRes(
            global::System.Collections.Generic.IList<byte[]> ids)
        {
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostCreateRes" /> class.
        /// </summary>
        public CostCreateRes()
        {
        }
    }
}