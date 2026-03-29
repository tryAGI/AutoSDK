//HintName: G.Models.ObjQueryRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjQueryRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ObjSchema> Objs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjQueryRes" /> class.
        /// </summary>
        /// <param name="objs"></param>
        public ObjQueryRes(
            global::System.Collections.Generic.IList<global::G.ObjSchema> objs)
        {
            this.Objs = objs ?? throw new global::System.ArgumentNullException(nameof(objs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjQueryRes" /> class.
        /// </summary>
        public ObjQueryRes()
        {
        }
    }
}