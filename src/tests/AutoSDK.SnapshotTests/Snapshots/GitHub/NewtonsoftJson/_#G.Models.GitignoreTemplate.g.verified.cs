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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public string Source { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}