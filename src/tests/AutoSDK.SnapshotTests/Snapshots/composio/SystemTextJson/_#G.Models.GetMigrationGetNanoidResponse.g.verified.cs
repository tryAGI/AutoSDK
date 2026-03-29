//HintName: G.Models.GetMigrationGetNanoidResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMigrationGetNanoidResponse
    {
        /// <summary>
        /// The NanoId corresponding to the provided UUID. This is the new identifier that should be used in place of the legacy UUID.<br/>
        /// Example: XqXrPalt3v
        /// </summary>
        /// <example>XqXrPalt3v</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nanoid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Nanoid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMigrationGetNanoidResponse" /> class.
        /// </summary>
        /// <param name="nanoid">
        /// The NanoId corresponding to the provided UUID. This is the new identifier that should be used in place of the legacy UUID.<br/>
        /// Example: XqXrPalt3v
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMigrationGetNanoidResponse(
            string nanoid)
        {
            this.Nanoid = nanoid ?? throw new global::System.ArgumentNullException(nameof(nanoid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMigrationGetNanoidResponse" /> class.
        /// </summary>
        public GetMigrationGetNanoidResponse()
        {
        }
    }
}