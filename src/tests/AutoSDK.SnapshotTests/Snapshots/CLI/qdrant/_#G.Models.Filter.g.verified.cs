//HintName: G.Models.Filter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Filter
    {
        /// <summary>
        /// At least one of those conditions should match
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("should")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.Condition?, global::System.Collections.Generic.IList<global::G.Condition>, object>))]
        public global::G.AnyOf<global::G.Condition?, global::System.Collections.Generic.IList<global::G.Condition>, object>? Should { get; set; }

        /// <summary>
        /// At least minimum amount of given conditions should match
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_should")]
        public global::G.MinShould? MinShould { get; set; }

        /// <summary>
        /// All conditions must match
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("must")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.Condition?, global::System.Collections.Generic.IList<global::G.Condition>, object>))]
        public global::G.AnyOf<global::G.Condition?, global::System.Collections.Generic.IList<global::G.Condition>, object>? Must { get; set; }

        /// <summary>
        /// All conditions must NOT match
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("must_not")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.Condition?, global::System.Collections.Generic.IList<global::G.Condition>, object>))]
        public global::G.AnyOf<global::G.Condition?, global::System.Collections.Generic.IList<global::G.Condition>, object>? MustNot { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter" /> class.
        /// </summary>
        /// <param name="should">
        /// At least one of those conditions should match
        /// </param>
        /// <param name="minShould">
        /// At least minimum amount of given conditions should match
        /// </param>
        /// <param name="must">
        /// All conditions must match
        /// </param>
        /// <param name="mustNot">
        /// All conditions must NOT match
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Filter(
            global::G.AnyOf<global::G.Condition?, global::System.Collections.Generic.IList<global::G.Condition>, object>? should,
            global::G.MinShould? minShould,
            global::G.AnyOf<global::G.Condition?, global::System.Collections.Generic.IList<global::G.Condition>, object>? must,
            global::G.AnyOf<global::G.Condition?, global::System.Collections.Generic.IList<global::G.Condition>, object>? mustNot)
        {
            this.Should = should;
            this.MinShould = minShould;
            this.Must = must;
            this.MustNot = mustNot;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter" /> class.
        /// </summary>
        public Filter()
        {
        }
    }
}