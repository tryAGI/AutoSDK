//HintName: G.Models.GetFieldOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Access a field on the traced call.<br/>
    /// Supports dot notation for nested access, e.g. `summary.usage.tokens`.<br/>
    /// Only works on fields present in the `CallSchema`, including:<br/>
    /// - Top-level fields like `op_name`, `trace_id`, `started_at`<br/>
    /// - Nested fields like `inputs.input_name`, `summary.usage.tokens`, etc.<br/>
    /// Example:<br/>
    ///     ```<br/>
    ///     {"$getField": "op_name"}<br/>
    ///     ```
    /// </summary>
    public sealed partial class GetFieldOperator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$getField")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string x_getField { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFieldOperator" /> class.
        /// </summary>
        /// <param name="x_getField"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFieldOperator(
            string x_getField)
        {
            this.x_getField = x_getField ?? throw new global::System.ArgumentNullException(nameof(x_getField));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFieldOperator" /> class.
        /// </summary>
        public GetFieldOperator()
        {
        }
    }
}