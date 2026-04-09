//HintName: G.IModelsClient.ModelsCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Create a model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Model> ModelsCreateAsync(

            global::G.CreateModelRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a model
        /// </summary>
        /// <param name="modelName">
        /// Name of the model definition. If multiple with the same name exist, they are applied in the following order: (1) custom over built-in, (2) newest according to startTime where model.startTime&lt;observation.startTime
        /// </param>
        /// <param name="matchPattern">
        /// Regex pattern which matches this model definition to generation.model. Useful in case of fine-tuned models. If you want to exact match, use `(?i)^modelname$`
        /// </param>
        /// <param name="startDate">
        /// Apply only to generations which are newer than this ISO date.
        /// </param>
        /// <param name="unit">
        /// Unit of usage in Langfuse
        /// </param>
        /// <param name="inputPrice">
        /// Deprecated. Use 'pricingTiers' instead. Price (USD) per input unit. Creates a default tier if pricingTiers not provided.
        /// </param>
        /// <param name="outputPrice">
        /// Deprecated. Use 'pricingTiers' instead. Price (USD) per output unit. Creates a default tier if pricingTiers not provided.
        /// </param>
        /// <param name="totalPrice">
        /// Deprecated. Use 'pricingTiers' instead. Price (USD) per total units. Cannot be set if input or output price is set. Creates a default tier if pricingTiers not provided.
        /// </param>
        /// <param name="pricingTiers">
        /// Optional. Array of pricing tiers for this model.<br/>
        /// Use pricing tiers for all models - both those with threshold-based pricing variations and those with simple flat pricing:<br/>
        /// - For models with standard flat pricing: Create a single default tier with your prices<br/>
        ///   (e.g., one tier with isDefault=true, priority=0, conditions=[], and your standard prices)<br/>
        /// - For models with threshold-based pricing: Create a default tier plus additional conditional tiers<br/>
        ///   (e.g., default tier for standard usage + high-volume tier for usage above certain thresholds)<br/>
        /// Requirements:<br/>
        /// - Cannot be provided with flat prices (inputPrice/outputPrice/totalPrice) - use one approach or the other<br/>
        /// - Must include exactly one default tier with isDefault=true, priority=0, and conditions=[]<br/>
        /// - All tier names and priorities must be unique within the model<br/>
        /// - Each tier must define at least one price<br/>
        /// If omitted, you must provide flat prices instead (inputPrice/outputPrice/totalPrice),<br/>
        /// which will automatically create a single default tier named "Standard".
        /// </param>
        /// <param name="tokenizerId">
        /// Optional. Tokenizer to be applied to observations which match to this model. See docs for more details.
        /// </param>
        /// <param name="tokenizerConfig">
        /// Optional. Configuration for the selected tokenizer. Needs to be JSON. See docs for more details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Model> ModelsCreateAsync(
            string modelName,
            string matchPattern,
            global::System.DateTime? startDate = default,
            global::G.ModelUsageUnit? unit = default,
            double? inputPrice = default,
            double? outputPrice = default,
            double? totalPrice = default,
            global::System.Collections.Generic.IList<global::G.PricingTierInput>? pricingTiers = default,
            string? tokenizerId = default,
            object? tokenizerConfig = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}