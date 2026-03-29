//HintName: G.Models.EditImageGetVirtualModelModelVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditImageGetVirtualModelModelVariant2
    {
        /// <summary>
        /// Use a custom model image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EditImageGetVirtualModelModelVariant2Custom Custom { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetVirtualModelModelVariant2" /> class.
        /// </summary>
        /// <param name="custom">
        /// Use a custom model image.
        /// </param>
        public EditImageGetVirtualModelModelVariant2(
            global::G.EditImageGetVirtualModelModelVariant2Custom custom)
        {
            this.Custom = custom ?? throw new global::System.ArgumentNullException(nameof(custom));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetVirtualModelModelVariant2" /> class.
        /// </summary>
        public EditImageGetVirtualModelModelVariant2()
        {
        }
    }
}