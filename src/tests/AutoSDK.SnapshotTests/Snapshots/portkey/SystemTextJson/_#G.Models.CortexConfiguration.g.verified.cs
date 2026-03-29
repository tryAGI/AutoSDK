//HintName: G.Models.CortexConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CortexConfiguration
    {
        /// <summary>
        /// Snowflake account identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snowflake_account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SnowflakeAccount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CortexConfiguration" /> class.
        /// </summary>
        /// <param name="snowflakeAccount">
        /// Snowflake account identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CortexConfiguration(
            string snowflakeAccount)
        {
            this.SnowflakeAccount = snowflakeAccount ?? throw new global::System.ArgumentNullException(nameof(snowflakeAccount));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CortexConfiguration" /> class.
        /// </summary>
        public CortexConfiguration()
        {
        }
    }
}