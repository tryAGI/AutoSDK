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
        [global::Newtonsoft.Json.JsonProperty("nanoid", Required = global::Newtonsoft.Json.Required.Always)]
        public string Nanoid { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMigrationGetNanoidResponse" /> class.
        /// </summary>
        /// <param name="nanoid">
        /// The NanoId corresponding to the provided UUID. This is the new identifier that should be used in place of the legacy UUID.<br/>
        /// Example: XqXrPalt3v
        /// </param>
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