//HintName: G.Models.Pricing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// All pricing values are in USD per 1 token.<br/>
    /// Pricing fields are in string format to avoid floating point precision issues.
    /// </summary>
    public sealed partial class Pricing
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion", Required = global::Newtonsoft.Json.Required.Always)]
        public string Completion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image", Required = global::Newtonsoft.Json.Required.Always)]
        public string Image { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request", Required = global::Newtonsoft.Json.Required.Always)]
        public string Request { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_cache_reads", Required = global::Newtonsoft.Json.Required.Always)]
        public string InputCacheReads { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_cache_writes", Required = global::Newtonsoft.Json.Required.Always)]
        public string InputCacheWrites { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pricing" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="completion"></param>
        /// <param name="image"></param>
        /// <param name="request"></param>
        /// <param name="inputCacheReads"></param>
        /// <param name="inputCacheWrites"></param>
        public Pricing(
            string prompt,
            string completion,
            string image,
            string request,
            string inputCacheReads,
            string inputCacheWrites)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Completion = completion ?? throw new global::System.ArgumentNullException(nameof(completion));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.InputCacheReads = inputCacheReads ?? throw new global::System.ArgumentNullException(nameof(inputCacheReads));
            this.InputCacheWrites = inputCacheWrites ?? throw new global::System.ArgumentNullException(nameof(inputCacheWrites));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pricing" /> class.
        /// </summary>
        public Pricing()
        {
        }
    }
}