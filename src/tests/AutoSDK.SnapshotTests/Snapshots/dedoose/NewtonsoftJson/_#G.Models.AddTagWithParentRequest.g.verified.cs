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
        [global::Newtonsoft.Json.JsonProperty("proejctId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProejctId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parentTagId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ParentTagId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isWeighted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsWeighted { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weightMin")]
        public double? WeightMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weightMax")]
        public double? WeightMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weightDefault")]
        public double? WeightDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowDecimalWeights", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AllowDecimalWeights { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color", Required = global::Newtonsoft.Json.Required.Always)]
        public double Color { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public AddTagWithParentRequest(
            global::System.Guid proejctId,
            global::System.Guid parentTagId,
            string title,
            string description,
            bool isWeighted,
            bool allowDecimalWeights,
            double color,
            double? weightMin,
            double? weightMax,
            double? weightDefault)
        {
            this.ProejctId = proejctId;
            this.ParentTagId = parentTagId;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IsWeighted = isWeighted;
            this.AllowDecimalWeights = allowDecimalWeights;
            this.Color = color;
            this.WeightMin = weightMin;
            this.WeightMax = weightMax;
            this.WeightDefault = weightDefault;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTagWithParentRequest" /> class.
        /// </summary>
        public AddTagWithParentRequest()
        {
        }
    }
}