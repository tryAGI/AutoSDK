//HintName: G.Models.TokenPatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model for patching an API token
    /// </summary>
    public sealed partial class TokenPatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenPatch" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isEnabled"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TokenPatch(
            string? name,
            bool? isEnabled)
        {
            this.Name = name;
            this.IsEnabled = isEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenPatch" /> class.
        /// </summary>
        public TokenPatch()
        {
        }
    }
}