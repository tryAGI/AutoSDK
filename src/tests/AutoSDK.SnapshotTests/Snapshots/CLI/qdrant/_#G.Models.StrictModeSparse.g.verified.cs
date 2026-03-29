//HintName: G.Models.StrictModeSparse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StrictModeSparse
    {
        /// <summary>
        /// Max length of sparse vector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_length")]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StrictModeSparse" /> class.
        /// </summary>
        /// <param name="maxLength">
        /// Max length of sparse vector
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StrictModeSparse(
            int? maxLength)
        {
            this.MaxLength = maxLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StrictModeSparse" /> class.
        /// </summary>
        public StrictModeSparse()
        {
        }
    }
}