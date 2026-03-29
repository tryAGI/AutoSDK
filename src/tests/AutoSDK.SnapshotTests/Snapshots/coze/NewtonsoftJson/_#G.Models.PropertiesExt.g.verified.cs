//HintName: G.Models.PropertiesExt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 用于指定一些额外的字段，非必要可不填写
    /// </summary>
    public sealed partial class PropertiesExt
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}