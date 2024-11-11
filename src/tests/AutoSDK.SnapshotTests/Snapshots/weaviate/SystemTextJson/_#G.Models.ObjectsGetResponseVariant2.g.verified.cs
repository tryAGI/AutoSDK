//HintName: G.Models.ObjectsGetResponseVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjectsGetResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecations")]
        public global::System.Collections.Generic.IList<global::G.Deprecation>? Deprecations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsGetResponseVariant2" /> class.
        /// </summary>
        /// <param name="deprecations"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ObjectsGetResponseVariant2(
            global::System.Collections.Generic.IList<global::G.Deprecation>? deprecations)
        {
            this.Deprecations = deprecations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsGetResponseVariant2" /> class.
        /// </summary>
        public ObjectsGetResponseVariant2()
        {
        }
    }
}