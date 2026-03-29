//HintName: G.Models.ModelsToCompare.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelsToCompare
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Parent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsToCompare" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="names"></param>
        /// <param name="parent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsToCompare(
            string provider,
            global::System.Collections.Generic.IList<string> names,
            string parent)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Names = names ?? throw new global::System.ArgumentNullException(nameof(names));
            this.Parent = parent ?? throw new global::System.ArgumentNullException(nameof(parent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsToCompare" /> class.
        /// </summary>
        public ModelsToCompare()
        {
        }
    }
}