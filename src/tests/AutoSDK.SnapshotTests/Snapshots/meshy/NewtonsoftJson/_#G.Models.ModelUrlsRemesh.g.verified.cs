//HintName: G.Models.ModelUrlsRemesh.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelUrlsRemesh
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
        [global::Newtonsoft.Json.JsonProperty("blend")]
        public string? Blend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stl")]
        public string? Stl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelUrlsRemesh" /> class.
        /// </summary>
        /// <param name="glb"></param>
        /// <param name="fbx"></param>
        /// <param name="obj"></param>
        /// <param name="usdz"></param>
        /// <param name="blend"></param>
        /// <param name="stl"></param>
        public ModelUrlsRemesh(
            string? glb,
            string? fbx,
            string? obj,
            string? usdz,
            string? blend,
            string? stl)
        {
            this.Glb = glb;
            this.Fbx = fbx;
            this.Obj = obj;
            this.Usdz = usdz;
            this.Blend = blend;
            this.Stl = stl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelUrlsRemesh" /> class.
        /// </summary>
        public ModelUrlsRemesh()
        {
        }
    }
}