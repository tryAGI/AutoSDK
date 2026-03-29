//HintName: G.Models.TriggeredBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ModelSerializer that takes additional arguments for<br/>
    /// "fields", "omit" and "expand" in order to<br/>
    /// control which fields are displayed, and whether to replace simple<br/>
    /// values with complex, nested serializations
    /// </summary>
    public sealed partial class TriggeredBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggeredBy" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggeredBy(
            string? email,
            int id = default!)
        {
            this.Email = email;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggeredBy" /> class.
        /// </summary>
        public TriggeredBy()
        {
        }
    }
}