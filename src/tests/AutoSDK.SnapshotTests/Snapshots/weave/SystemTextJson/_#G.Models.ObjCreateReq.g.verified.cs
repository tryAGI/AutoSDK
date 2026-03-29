//HintName: G.Models.ObjCreateReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjCreateReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("obj")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ObjSchemaForInsert Obj { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjCreateReq" /> class.
        /// </summary>
        /// <param name="obj"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObjCreateReq(
            global::G.ObjSchemaForInsert obj)
        {
            this.Obj = obj ?? throw new global::System.ArgumentNullException(nameof(obj));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjCreateReq" /> class.
        /// </summary>
        public ObjCreateReq()
        {
        }
    }
}