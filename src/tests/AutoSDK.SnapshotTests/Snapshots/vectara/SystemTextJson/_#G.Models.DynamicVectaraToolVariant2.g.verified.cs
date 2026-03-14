//HintName: G.Models.DynamicVectaraToolVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DynamicVectaraToolVariant2
    {
        /// <summary>
        /// This should always be `dynamic_vectara`.<br/>
        /// Default Value: dynamic_vectara<br/>
        /// Example: dynamic_vectara
        /// </summary>
        /// <default>"dynamic_vectara"</default>
        /// <example>dynamic_vectara</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "dynamic_vectara";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicVectaraToolVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `dynamic_vectara`.<br/>
        /// Default Value: dynamic_vectara<br/>
        /// Example: dynamic_vectara
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DynamicVectaraToolVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicVectaraToolVariant2" /> class.
        /// </summary>
        public DynamicVectaraToolVariant2()
        {
        }
    }
}