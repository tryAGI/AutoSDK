//HintName: G.Models.PropertiesPluginIdList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesPluginIdList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id_list")]
        public global::System.Collections.Generic.IList<global::G.PropertiesPluginIdListPropertiesIdListItems>? IdList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPluginIdList" /> class.
        /// </summary>
        /// <param name="idList"></param>
        public PropertiesPluginIdList(
            global::System.Collections.Generic.IList<global::G.PropertiesPluginIdListPropertiesIdListItems>? idList)
        {
            this.IdList = idList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPluginIdList" /> class.
        /// </summary>
        public PropertiesPluginIdList()
        {
        }
    }
}