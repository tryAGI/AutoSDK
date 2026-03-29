//HintName: G.Models.ProjectStatItemObjectPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPolymorphic(
        TypeDiscriminatorPropertyName = "type",
        IgnoreUnrecognizedTypeDiscriminators = true,
        UnknownDerivedTypeHandling = global::System.Text.Json.Serialization.JsonUnknownDerivedTypeHandling.FallBackToBaseType)]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.AvgValueStatPublic), typeDiscriminator: "AVG")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.CountValueStatPublic), typeDiscriminator: "COUNT")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.PercentageValueStatPublic), typeDiscriminator: "PERCENTAGE")]
    public partial class ProjectStatItemObjectPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStatItemObjectPublic" /> class.
        /// </summary>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectStatItemObjectPublic(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStatItemObjectPublic" /> class.
        /// </summary>
        public ProjectStatItemObjectPublic()
        {
        }
    }
}