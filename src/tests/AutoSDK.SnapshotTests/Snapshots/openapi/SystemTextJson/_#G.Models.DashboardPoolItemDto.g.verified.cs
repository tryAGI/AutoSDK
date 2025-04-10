//HintName: G.Models.DashboardPoolItemDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DashboardPoolItemDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weakerLegVolume")]
        public int? WeakerLegVolume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageRequirement")]
        public int? PackageRequirement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("achievers")]
        public int? Achievers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimatedPoolReward")]
        public double? EstimatedPoolReward { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isCurrentPool")]
        public bool? IsCurrentPool { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardPoolItemDto" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weakerLegVolume"></param>
        /// <param name="packageRequirement"></param>
        /// <param name="achievers"></param>
        /// <param name="estimatedPoolReward"></param>
        /// <param name="isCurrentPool"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DashboardPoolItemDto(
            string? name,
            int? weakerLegVolume,
            int? packageRequirement,
            int? achievers,
            double? estimatedPoolReward,
            bool? isCurrentPool)
        {
            this.Name = name;
            this.WeakerLegVolume = weakerLegVolume;
            this.PackageRequirement = packageRequirement;
            this.Achievers = achievers;
            this.EstimatedPoolReward = estimatedPoolReward;
            this.IsCurrentPool = isCurrentPool;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardPoolItemDto" /> class.
        /// </summary>
        public DashboardPoolItemDto()
        {
        }
    }
}