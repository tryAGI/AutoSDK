//HintName: G.Models.Hotkeys.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Hotkeys
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_hotkeys", Required = global::Newtonsoft.Json.Required.Always)]
        public object CustomHotkeys { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Hotkeys" /> class.
        /// </summary>
        /// <param name="customHotkeys"></param>
        public Hotkeys(
            object customHotkeys)
        {
            this.CustomHotkeys = customHotkeys ?? throw new global::System.ArgumentNullException(nameof(customHotkeys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hotkeys" /> class.
        /// </summary>
        public Hotkeys()
        {
        }
    }
}