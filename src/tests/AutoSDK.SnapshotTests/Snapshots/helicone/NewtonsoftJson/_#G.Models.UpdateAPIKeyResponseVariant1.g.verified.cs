//HintName: G.Models.UpdateAPIKeyResponseVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAPIKeyResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hashedKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string HashedKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAPIKeyResponseVariant1" /> class.
        /// </summary>
        /// <param name="hashedKey"></param>
        public UpdateAPIKeyResponseVariant1(
            string hashedKey)
        {
            this.HashedKey = hashedKey ?? throw new global::System.ArgumentNullException(nameof(hashedKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAPIKeyResponseVariant1" /> class.
        /// </summary>
        public UpdateAPIKeyResponseVariant1()
        {
        }
    }
}