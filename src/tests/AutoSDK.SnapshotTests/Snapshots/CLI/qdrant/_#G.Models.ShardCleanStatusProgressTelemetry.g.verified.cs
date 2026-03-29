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
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DeletedPoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardCleanStatusProgressTelemetry" /> class.
        /// </summary>
        /// <param name="deletedPoints"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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