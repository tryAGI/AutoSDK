//HintName: G.Models.OpenCreateSpaceRet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenCreateSpaceRet
    {
        /// <summary>
        /// 空间id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenCreateSpaceRet" /> class.
        /// </summary>
        /// <param name="id">
        /// 空间id
        /// </param>
        public OpenCreateSpaceRet(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenCreateSpaceRet" /> class.
        /// </summary>
        public OpenCreateSpaceRet()
        {
        }
    }
}