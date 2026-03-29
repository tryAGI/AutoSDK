//HintName: G.Models.CodeBundleLocationVariant3SandboxSpecVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeBundleLocationVariant3SandboxSpecVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CodeBundleLocationVariant3SandboxSpecVariant1Provider Provider { get; set; }

        /// <summary>
        /// sandbox snapshot ref
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("snapshot_ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string SnapshotRef { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundleLocationVariant3SandboxSpecVariant1" /> class.
        /// </summary>
        /// <param name="snapshotRef">
        /// sandbox snapshot ref
        /// </param>
        /// <param name="provider"></param>
        public CodeBundleLocationVariant3SandboxSpecVariant1(
            string snapshotRef,
            global::G.CodeBundleLocationVariant3SandboxSpecVariant1Provider provider)
        {
            this.Provider = provider;
            this.SnapshotRef = snapshotRef ?? throw new global::System.ArgumentNullException(nameof(snapshotRef));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundleLocationVariant3SandboxSpecVariant1" /> class.
        /// </summary>
        public CodeBundleLocationVariant3SandboxSpecVariant1()
        {
        }
    }
}