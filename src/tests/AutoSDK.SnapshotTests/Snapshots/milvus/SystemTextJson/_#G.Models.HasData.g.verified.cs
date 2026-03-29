//HintName: G.Models.HasData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HasData
    {
        /// <summary>
        /// A boolean value indicates whether the specified partition exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Has { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HasData" /> class.
        /// </summary>
        /// <param name="has">
        /// A boolean value indicates whether the specified partition exists.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HasData(
            bool has)
        {
            this.Has = has;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HasData" /> class.
        /// </summary>
        public HasData()
        {
        }
    }
}