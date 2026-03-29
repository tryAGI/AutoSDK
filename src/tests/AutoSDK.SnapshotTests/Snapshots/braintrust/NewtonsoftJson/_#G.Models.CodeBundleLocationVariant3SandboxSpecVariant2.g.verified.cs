//HintName: G.Models.CodeBundleLocationVariant3SandboxSpecVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeBundleLocationVariant3SandboxSpecVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CodeBundleLocationVariant3SandboxSpecVariant2Provider Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundleLocationVariant3SandboxSpecVariant2" /> class.
        /// </summary>
        /// <param name="provider"></param>
        public CodeBundleLocationVariant3SandboxSpecVariant2(
            global::G.CodeBundleLocationVariant3SandboxSpecVariant2Provider provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBundleLocationVariant3SandboxSpecVariant2" /> class.
        /// </summary>
        public CodeBundleLocationVariant3SandboxSpecVariant2()
        {
        }
    }
}