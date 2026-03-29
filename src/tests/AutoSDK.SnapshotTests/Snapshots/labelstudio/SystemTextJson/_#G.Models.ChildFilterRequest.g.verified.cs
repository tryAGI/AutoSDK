//HintName: G.Models.ChildFilterRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChildFilterRequest
    {
        /// <summary>
        /// Field name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Column { get; set; }

        /// <summary>
        /// Display order among root filters only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Filter operator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operator { get; set; }

        /// <summary>
        /// Optional parent filter to create one-level hierarchy (child filters are AND-merged with parent)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        public int? Parent { get; set; }

        /// <summary>
        /// Field type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Filter value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChildFilterRequest" /> class.
        /// </summary>
        /// <param name="column">
        /// Field name
        /// </param>
        /// <param name="operator">
        /// Filter operator
        /// </param>
        /// <param name="type">
        /// Field type
        /// </param>
        /// <param name="index">
        /// Display order among root filters only
        /// </param>
        /// <param name="parent">
        /// Optional parent filter to create one-level hierarchy (child filters are AND-merged with parent)
        /// </param>
        /// <param name="value">
        /// Filter value
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChildFilterRequest(
            string column,
            string @operator,
            string type,
            int? index,
            int? parent,
            object? value)
        {
            this.Column = column ?? throw new global::System.ArgumentNullException(nameof(column));
            this.Index = index;
            this.Operator = @operator ?? throw new global::System.ArgumentNullException(nameof(@operator));
            this.Parent = parent;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChildFilterRequest" /> class.
        /// </summary>
        public ChildFilterRequest()
        {
        }
    }
}