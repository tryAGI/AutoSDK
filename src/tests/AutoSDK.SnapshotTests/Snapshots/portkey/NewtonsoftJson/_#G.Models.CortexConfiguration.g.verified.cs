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
        [global::Newtonsoft.Json.JsonProperty("snowflake_account", Required = global::Newtonsoft.Json.Required.Always)]
        public string SnowflakeAccount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CortexConfiguration" /> class.
        /// </summary>
        /// <param name="snowflakeAccount">
        /// Snowflake account identifier
        /// </param>
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