//HintName: G.Models.AddTagRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddTagRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isWeighted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsWeighted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightMin")]
        public double? WeightMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightMax")]
        public double? WeightMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightDefault")]
        public double? WeightDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowDecimalWeights")]
        public bool? AllowDecimalWeights { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTagRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="isWeighted"></param>
        /// <param name="color"></param>
        /// <param name="weightMin"></param>
        /// <param name="weightMax"></param>
        /// <param name="weightDefault"></param>
        /// <param name="allowDecimalWeights"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddTagRequest(
            global::System.Guid projectId,
            string title,
            string description,
            bool isWeighted,
            int color,
            double? weightMin,
            double? weightMax,
            double? weightDefault,
            bool? allowDecimalWeights)
        {
            this.ProjectId = projectId;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IsWeighted = isWeighted;
            this.WeightMin = weightMin;
            this.WeightMax = weightMax;
            this.WeightDefault = weightDefault;
            this.AllowDecimalWeights = allowDecimalWeights;
            this.Color = color;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTagRequest" /> class.
        /// </summary>
        public AddTagRequest()
        {
        }
    }
}