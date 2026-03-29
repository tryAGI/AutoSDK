//HintName: G.Models.ConvertOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Convert the input value to a specific type (e.g., `int`, `bool`, `string`).<br/>
    /// Example:<br/>
    ///     ```<br/>
    ///     {<br/>
    ///         "$convert": {<br/>
    ///             "input": {"$getField": "inputs.value"},<br/>
    ///             "to": "int"<br/>
    ///         }<br/>
    ///     }<br/>
    ///     ```
    /// </summary>
    public sealed partial class ConvertOperation
    {
        /// <summary>
        /// Specifies conversion details for `$convert`.<br/>
        /// - `input`: The operand to convert.<br/>
        /// - `to`: The type to convert to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$convert")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConvertSpec x_convert { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertOperation" /> class.
        /// </summary>
        /// <param name="x_convert">
        /// Specifies conversion details for `$convert`.<br/>
        /// - `input`: The operand to convert.<br/>
        /// - `to`: The type to convert to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConvertOperation(
            global::G.ConvertSpec x_convert)
        {
            this.x_convert = x_convert ?? throw new global::System.ArgumentNullException(nameof(x_convert));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertOperation" /> class.
        /// </summary>
        public ConvertOperation()
        {
        }
    }
}