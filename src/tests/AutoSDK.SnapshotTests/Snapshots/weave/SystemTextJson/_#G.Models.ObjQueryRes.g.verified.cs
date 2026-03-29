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
        [global::System.Text.Json.Serialization.JsonPropertyName("objs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ObjSchema> Objs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjQueryRes" /> class.
        /// </summary>
        /// <param name="objs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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