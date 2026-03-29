//HintName: G.Models.ObjReadRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjReadRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("obj", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ObjSchema Obj { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjReadRes" /> class.
        /// </summary>
        /// <param name="obj"></param>
        public ObjReadRes(
            global::G.ObjSchema obj)
        {
            this.Obj = obj ?? throw new global::System.ArgumentNullException(nameof(obj));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjReadRes" /> class.
        /// </summary>
        public ObjReadRes()
        {
        }
    }
}