//HintName: G.Models.CodeBundle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeBundle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runtime_context", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodeBundleRuntimeContext RuntimeContext { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("location", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.CodeBundleLocationExperiment, global::G.CodeBundleLocationFunction, global::G.CodeBundleLocationVariant3> Location { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bundle_id")]
        public string? BundleId { get; set; }

        /// <summary>
        /// A preview of the code
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview")]
        public string? Preview { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundle" /> class.
        /// </summary>
        /// <param name="runtimeContext"></param>
        /// <param name="location"></param>
        /// <param name="bundleId"></param>
        /// <param name="preview">
        /// A preview of the code
        /// </param>
        public CodeBundle(
            global::G.CodeBundleRuntimeContext runtimeContext,
            global::G.AnyOf<global::G.CodeBundleLocationExperiment, global::G.CodeBundleLocationFunction, global::G.CodeBundleLocationVariant3> location,
            string? bundleId,
            string? preview)
        {
            this.RuntimeContext = runtimeContext ?? throw new global::System.ArgumentNullException(nameof(runtimeContext));
            this.Location = location;
            this.BundleId = bundleId;
            this.Preview = preview;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundle" /> class.
        /// </summary>
        public CodeBundle()
        {
        }
    }
}