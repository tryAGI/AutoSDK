//HintName: G.Models.AddTagWithParentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddTagWithParentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proejctId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProejctId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentTagId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ParentTagId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double? WeightMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightMax")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double? WeightMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightDefault")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double? WeightDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowDecimalWeights")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowDecimalWeights { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTagWithParentRequest" /> class.
        /// </summary>
        /// <param name="proejctId"></param>
        /// <param name="parentTagId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="isWeighted"></param>
        /// <param name="weightMin"></param>
        /// <param name="weightMax"></param>
        /// <param name="weightDefault"></param>
        /// <param name="allowDecimalWeights"></param>
        /// <param name="color"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AddTagWithParentRequest(
            global::System.Guid proejctId,
            global::System.Guid parentTagId,
            string title,
            string description,
            bool isWeighted,
            double? weightMin,
            double? weightMax,
            double? weightDefault,
            bool allowDecimalWeights,
            double color)
        {
            this.ProejctId = proejctId;
            this.ParentTagId = parentTagId;
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
        /// Initializes a new instance of the <see cref="AddTagWithParentRequest" /> class.
        /// </summary>
        public AddTagWithParentRequest()
        {
        }
    }
}