//HintName: G.Models.GitignoreTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Gitignore Template
    /// </summary>
    public sealed partial class GitignoreTemplate
    {
        /// <summary>
        /// Example: C
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: # Object files<br/>
        /// *.o<br/>
        /// # Libraries<br/>
        /// *.lib<br/>
        /// *.a<br/>
        /// # Shared objects (inc. Windows DLLs)<br/>
        /// *.dll<br/>
        /// *.so<br/>
        /// *.so.*<br/>
        /// *.dylib<br/>
        /// # Executables<br/>
        /// *.exe<br/>
        /// *.out<br/>
        /// *.app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}