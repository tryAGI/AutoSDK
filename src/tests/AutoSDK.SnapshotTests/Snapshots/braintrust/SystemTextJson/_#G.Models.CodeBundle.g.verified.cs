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
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime_context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CodeBundleRuntimeContext RuntimeContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.CodeBundleLocationExperiment, global::G.CodeBundleLocationFunction, global::G.CodeBundleLocationVariant3>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.CodeBundleLocationExperiment, global::G.CodeBundleLocationFunction, global::G.CodeBundleLocationVariant3> Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundle_id")]
        public string? BundleId { get; set; }

        /// <summary>
        /// A preview of the code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        public string? Preview { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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