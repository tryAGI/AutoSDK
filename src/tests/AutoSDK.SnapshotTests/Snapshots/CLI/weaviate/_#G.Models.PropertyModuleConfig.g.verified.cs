﻿//HintName: G.Models.PropertyModuleConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration specific to modules in a property context.
    /// </summary>
    public sealed partial class PropertyModuleConfig
    {
        /// <summary>
        /// E.g. `text2vec-transformers`, `text2vec-openai`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("<module_name>")]
        public global::G.PropertyModuleConfig2? x_moduleName_ { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyModuleConfig" /> class.
        /// </summary>
        /// <param name="x_moduleName_">
        /// E.g. `text2vec-transformers`, `text2vec-openai`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertyModuleConfig(
            global::G.PropertyModuleConfig2? x_moduleName_)
        {
            this.x_moduleName_ = x_moduleName_;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyModuleConfig" /> class.
        /// </summary>
        public PropertyModuleConfig()
        {
        }
    }
}