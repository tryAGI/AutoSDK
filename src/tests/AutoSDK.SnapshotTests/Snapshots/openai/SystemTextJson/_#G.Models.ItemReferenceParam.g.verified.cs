//HintName: G.Models.ItemReferenceParam.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An internal identifier for an item to reference.
    /// </summary>
    public sealed partial class ItemReferenceParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.ItemReferenceParamType?, object>))]
        public global::G.AnyOf<global::G.ItemReferenceParamType?, object>? Type { get; set; }

        /// <summary>
        /// The ID of the item to reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemReferenceParam" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id">
        /// The ID of the item to reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ItemReferenceParam(
            string id,
            global::G.AnyOf<global::G.ItemReferenceParamType?, object>? type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemReferenceParam" /> class.
        /// </summary>
        public ItemReferenceParam()
        {
        }
    }
}