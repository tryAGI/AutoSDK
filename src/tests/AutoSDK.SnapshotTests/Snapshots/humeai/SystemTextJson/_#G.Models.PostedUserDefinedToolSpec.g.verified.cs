//HintName: G.Models.PostedUserDefinedToolSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedUserDefinedToolSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedUserDefinedToolSpec" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostedUserDefinedToolSpec(
            string? id,
            int? version)
        {
            this.Id = id;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedUserDefinedToolSpec" /> class.
        /// </summary>
        public PostedUserDefinedToolSpec()
        {
        }
    }
}