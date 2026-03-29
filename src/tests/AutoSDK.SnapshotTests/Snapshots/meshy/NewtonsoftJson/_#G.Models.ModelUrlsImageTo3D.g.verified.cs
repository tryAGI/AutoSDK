//HintName: G.Models.ModelUrlsImageTo3D.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelUrlsImageTo3D
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("glb")]
        public string? Glb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fbx")]
        public string? Fbx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("obj")]
        public string? Obj { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usdz")]
        public string? Usdz { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mtl")]
        public string? Mtl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stl")]
        public string? Stl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pre_remeshed_glb")]
        public string? PreRemeshedGlb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelUrlsImageTo3D" /> class.
        /// </summary>
        /// <param name="glb"></param>
        /// <param name="fbx"></param>
        /// <param name="obj"></param>
        /// <param name="usdz"></param>
        /// <param name="mtl"></param>
        /// <param name="stl"></param>
        /// <param name="preRemeshedGlb"></param>
        public ModelUrlsImageTo3D(
            string? glb,
            string? fbx,
            string? obj,
            string? usdz,
            string? mtl,
            string? stl,
            string? preRemeshedGlb)
        {
            this.Glb = glb;
            this.Fbx = fbx;
            this.Obj = obj;
            this.Usdz = usdz;
            this.Mtl = mtl;
            this.Stl = stl;
            this.PreRemeshedGlb = preRemeshedGlb;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelUrlsImageTo3D" /> class.
        /// </summary>
        public ModelUrlsImageTo3D()
        {
        }
    }
}