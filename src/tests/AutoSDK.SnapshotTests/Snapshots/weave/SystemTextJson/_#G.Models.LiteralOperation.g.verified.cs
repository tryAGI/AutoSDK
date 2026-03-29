//HintName: G.Models.LiteralOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a constant value in the query language.<br/>
    /// This can be any standard JSON-serializable value.<br/>
    /// Example:<br/>
    ///     ```<br/>
    ///     {"$literal": "predict"}<br/>
    ///     ```
    /// </summary>
    public sealed partial class LiteralOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$literal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.Dictionary<string, global::G.LiteralOperation>, global::System.Collections.Generic.IList<global::G.LiteralOperation>, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.Dictionary<string, global::G.LiteralOperation>, global::System.Collections.Generic.IList<global::G.LiteralOperation>, object> x_literal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteralOperation" /> class.
        /// </summary>
        /// <param name="x_literal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiteralOperation(
            global::G.AnyOf<string, int?, double?, bool?, global::System.Collections.Generic.Dictionary<string, global::G.LiteralOperation>, global::System.Collections.Generic.IList<global::G.LiteralOperation>, object> x_literal)
        {
            this.x_literal = x_literal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteralOperation" /> class.
        /// </summary>
        public LiteralOperation()
        {
        }
    }
}