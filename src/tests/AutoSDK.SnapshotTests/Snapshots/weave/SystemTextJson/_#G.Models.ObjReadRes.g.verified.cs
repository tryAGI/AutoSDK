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
        [global::System.Text.Json.Serialization.JsonPropertyName("obj")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ObjSchema Obj { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjReadRes" /> class.
        /// </summary>
        /// <param name="obj"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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