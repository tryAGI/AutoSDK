//HintName: G.Models.UpdatePresenterAttributesRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePresenterAttributesRequestVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ownerId")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePresenterAttributesRequestVariant2" /> class.
        /// </summary>
        /// <param name="ownerId"></param>
        public UpdatePresenterAttributesRequestVariant2(
            string? ownerId)
        {
            this.OwnerId = ownerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePresenterAttributesRequestVariant2" /> class.
        /// </summary>
        public UpdatePresenterAttributesRequestVariant2()
        {
        }
    }
}