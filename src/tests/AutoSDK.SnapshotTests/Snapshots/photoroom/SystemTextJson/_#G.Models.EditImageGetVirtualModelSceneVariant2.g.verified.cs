//HintName: G.Models.EditImageGetVirtualModelSceneVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditImageGetVirtualModelSceneVariant2
    {
        /// <summary>
        /// Use a custom scene image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EditImageGetVirtualModelSceneVariant2Custom Custom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetVirtualModelSceneVariant2" /> class.
        /// </summary>
        /// <param name="custom">
        /// Use a custom scene image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditImageGetVirtualModelSceneVariant2(
            global::G.EditImageGetVirtualModelSceneVariant2Custom custom)
        {
            this.Custom = custom ?? throw new global::System.ArgumentNullException(nameof(custom));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetVirtualModelSceneVariant2" /> class.
        /// </summary>
        public EditImageGetVirtualModelSceneVariant2()
        {
        }
    }
}