//HintName: G.Models.CreateExpressiveResponseDtoVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExpressiveResponseDtoVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.CreateExpressiveResponseDtoVariant2Object Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressiveResponseDtoVariant2" /> class.
        /// </summary>
        /// <param name="object"></param>
        public CreateExpressiveResponseDtoVariant2(
            global::G.CreateExpressiveResponseDtoVariant2Object @object)
        {
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressiveResponseDtoVariant2" /> class.
        /// </summary>
        public CreateExpressiveResponseDtoVariant2()
        {
        }
    }
}