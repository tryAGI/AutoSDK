//HintName: G.Models.UpdatePresenterAttributesVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePresenterAttributesVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("newOwnerId")]
        public string? NewOwnerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePresenterAttributesVariant3" /> class.
        /// </summary>
        /// <param name="newOwnerId"></param>
        public UpdatePresenterAttributesVariant3(
            string? newOwnerId)
        {
            this.NewOwnerId = newOwnerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePresenterAttributesVariant3" /> class.
        /// </summary>
        public UpdatePresenterAttributesVariant3()
        {
        }
    }
}