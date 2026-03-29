//HintName: G.Models.ShardCleanStatusProgressTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShardCleanStatusProgressTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_points", Required = global::Newtonsoft.Json.Required.Always)]
        public int DeletedPoints { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardCleanStatusProgressTelemetry" /> class.
        /// </summary>
        /// <param name="deletedPoints"></param>
        public ShardCleanStatusProgressTelemetry(
            int deletedPoints)
        {
            this.DeletedPoints = deletedPoints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardCleanStatusProgressTelemetry" /> class.
        /// </summary>
        public ShardCleanStatusProgressTelemetry()
        {
        }
    }
}