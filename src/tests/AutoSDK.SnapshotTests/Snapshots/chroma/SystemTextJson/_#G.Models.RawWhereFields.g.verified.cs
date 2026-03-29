//HintName: G.Models.RawWhereFields.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RawWhereFields
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("where")]
        public object? Where { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("where_document")]
        public object? WhereDocument { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RawWhereFields" /> class.
        /// </summary>
        /// <param name="where"></param>
        /// <param name="whereDocument"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RawWhereFields(
            object? where,
            object? whereDocument)
        {
            this.Where = where;
            this.WhereDocument = whereDocument;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RawWhereFields" /> class.
        /// </summary>
        public RawWhereFields()
        {
        }
    }
}