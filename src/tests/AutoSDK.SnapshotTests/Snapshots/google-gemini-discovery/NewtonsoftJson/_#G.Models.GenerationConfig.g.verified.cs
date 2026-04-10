//HintName: G.Models.GenerationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options for model generation and outputs. Not all parameters are configurable for every model.
    /// </summary>
    public sealed partial class GenerationConfig
    {
        /// <summary>
        /// Optional. Number of generated responses to return. If unset, this will default to 1. Please note that this doesn't work for previous generation models (Gemini 1.0 family)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("candidateCount")]
        public int? CandidateCount { get; set; }

        /// <summary>
        /// Optional. The set of character sequences (up to 5) that will stop output generation. If specified, the API will stop at the first appearance of a `stop_sequence`. The stop sequence will not be included as part of the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stopSequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// Optional. The maximum number of tokens to include in a response candidate. Note: The default value varies by model, see the `Model.output_token_limit` attribute of the `Model` returned from the `getModel` function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxOutputTokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Optional. Controls the randomness of the output. Note: The default value varies by model, see the `Model.temperature` attribute of the `Model` returned from the `getModel` function. Values can range from [0.0, 2.0].
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Optional. The maximum cumulative probability of tokens to consider when sampling. The model uses combined Top-k and Top-p (nucleus) sampling. Tokens are sorted based on their assigned probabilities so that only the most likely tokens are considered. Top-k sampling directly limits the maximum number of tokens to consider, while Nucleus sampling limits the number of tokens based on the cumulative probability. Note: The default value varies by `Model` and is specified by the`Model.top_p` attribute returned from the `getModel` function. An empty `top_k` attribute indicates that the model doesn't apply top-k sampling and doesn't allow setting `top_k` on requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topP")]
        public float? TopP { get; set; }

        /// <summary>
        /// Optional. The maximum number of tokens to consider when sampling. Gemini models use Top-p (nucleus) sampling or a combination of Top-k and nucleus sampling. Top-k sampling considers the set of `top_k` most probable tokens. Models running with nucleus sampling don't allow top_k setting. Note: The default value varies by `Model` and is specified by the`Model.top_p` attribute returned from the `getModel` function. An empty `top_k` attribute indicates that the model doesn't apply top-k sampling and doesn't allow setting `top_k` on requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topK")]
        public int? TopK { get; set; }

        /// <summary>
        /// Optional. Seed used in decoding. If not set, the request uses a randomly generated seed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Optional. MIME type of the generated candidate text. Supported MIME types are: `text/plain`: (default) Text output. `application/json`: JSON response in the response candidates. `text/x.enum`: ENUM as a string response in the response candidates. Refer to the [docs](https://ai.google.dev/gemini-api/docs/prompting_with_media#plain_text_formats) for a list of all supported text MIME types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("responseMimeType")]
        public string? ResponseMimeType { get; set; }

        /// <summary>
        /// The `Schema` object allows the definition of input and output data types. These types can be objects, but also primitives and arrays. Represents a select subset of an [OpenAPI 3.0 schema object](https://spec.openapis.org/oas/v3.0.3#schema).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("responseSchema")]
        public global::G.Schema? ResponseSchema { get; set; }

        /// <summary>
        /// Optional. An internal detail. Use `responseJsonSchema` rather than this field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("responseJsonSchema")]
        public object? ResponseJsonSchema { get; set; }

        /// <summary>
        /// Optional. Presence penalty applied to the next token's logprobs if the token has already been seen in the response. This penalty is binary on/off and not dependant on the number of times the token is used (after the first). Use frequency_penalty for a penalty that increases with each use. A positive penalty will discourage the use of tokens that have already been used in the response, increasing the vocabulary. A negative penalty will encourage the use of tokens that have already been used in the response, decreasing the vocabulary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presencePenalty")]
        public float? PresencePenalty { get; set; }

        /// <summary>
        /// Optional. Frequency penalty applied to the next token's logprobs, multiplied by the number of times each token has been seen in the respponse so far. A positive penalty will discourage the use of tokens that have already been used, proportional to the number of times the token has been used: The more a token is used, the more difficult it is for the model to use that token again increasing the vocabulary of responses. Caution: A _negative_ penalty will encourage the model to reuse tokens proportional to the number of times the token has been used. Small negative values will reduce the vocabulary of a response. Larger negative values will cause the model to start repeating a common token until it hits the max_output_tokens limit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequencyPenalty")]
        public float? FrequencyPenalty { get; set; }

        /// <summary>
        /// Optional. If true, export the logprobs results in response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("responseLogprobs")]
        public bool? ResponseLogprobs { get; set; }

        /// <summary>
        /// Optional. Only valid if response_logprobs=True. This sets the number of top logprobs, including the chosen candidate, to return at each decoding step in the Candidate.logprobs_result. The number must be in the range of [0, 20].
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public int? Logprobs { get; set; }

        /// <summary>
        /// Optional. Enables enhanced civic answers. It may not be available for all models.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enableEnhancedCivicAnswers")]
        public bool? EnableEnhancedCivicAnswers { get; set; }

        /// <summary>
        /// Optional. The requested modalities of the response. Represents the set of modalities that the model can return, and should be expected in the response. This is an exact match to the modalities of the response. A model may have multiple combinations of supported modalities. If the requested modalities do not match any of the supported combinations, an error will be returned. An empty list is equivalent to requesting only text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("responseModalities")]
        public global::System.Collections.Generic.IList<global::G.GenerationConfigResponseModalitie>? ResponseModalities { get; set; }

        /// <summary>
        /// Config for speech generation and transcription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speechConfig")]
        public global::G.SpeechConfig? SpeechConfig { get; set; }

        /// <summary>
        /// Config for thinking features.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thinkingConfig")]
        public global::G.ThinkingConfig? ThinkingConfig { get; set; }

        /// <summary>
        /// Config for image generation features.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("imageConfig")]
        public global::G.ImageConfig? ImageConfig { get; set; }

        /// <summary>
        /// Optional. If specified, the media resolution specified will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mediaResolution")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GenerationConfigMediaResolutionJsonConverter))]
        public global::G.GenerationConfigMediaResolution? MediaResolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationConfig" /> class.
        /// </summary>
        /// <param name="candidateCount">
        /// Optional. Number of generated responses to return. If unset, this will default to 1. Please note that this doesn't work for previous generation models (Gemini 1.0 family)
        /// </param>
        /// <param name="stopSequences">
        /// Optional. The set of character sequences (up to 5) that will stop output generation. If specified, the API will stop at the first appearance of a `stop_sequence`. The stop sequence will not be included as part of the response.
        /// </param>
        /// <param name="maxOutputTokens">
        /// Optional. The maximum number of tokens to include in a response candidate. Note: The default value varies by model, see the `Model.output_token_limit` attribute of the `Model` returned from the `getModel` function.
        /// </param>
        /// <param name="temperature">
        /// Optional. Controls the randomness of the output. Note: The default value varies by model, see the `Model.temperature` attribute of the `Model` returned from the `getModel` function. Values can range from [0.0, 2.0].
        /// </param>
        /// <param name="topP">
        /// Optional. The maximum cumulative probability of tokens to consider when sampling. The model uses combined Top-k and Top-p (nucleus) sampling. Tokens are sorted based on their assigned probabilities so that only the most likely tokens are considered. Top-k sampling directly limits the maximum number of tokens to consider, while Nucleus sampling limits the number of tokens based on the cumulative probability. Note: The default value varies by `Model` and is specified by the`Model.top_p` attribute returned from the `getModel` function. An empty `top_k` attribute indicates that the model doesn't apply top-k sampling and doesn't allow setting `top_k` on requests.
        /// </param>
        /// <param name="topK">
        /// Optional. The maximum number of tokens to consider when sampling. Gemini models use Top-p (nucleus) sampling or a combination of Top-k and nucleus sampling. Top-k sampling considers the set of `top_k` most probable tokens. Models running with nucleus sampling don't allow top_k setting. Note: The default value varies by `Model` and is specified by the`Model.top_p` attribute returned from the `getModel` function. An empty `top_k` attribute indicates that the model doesn't apply top-k sampling and doesn't allow setting `top_k` on requests.
        /// </param>
        /// <param name="seed">
        /// Optional. Seed used in decoding. If not set, the request uses a randomly generated seed.
        /// </param>
        /// <param name="responseMimeType">
        /// Optional. MIME type of the generated candidate text. Supported MIME types are: `text/plain`: (default) Text output. `application/json`: JSON response in the response candidates. `text/x.enum`: ENUM as a string response in the response candidates. Refer to the [docs](https://ai.google.dev/gemini-api/docs/prompting_with_media#plain_text_formats) for a list of all supported text MIME types.
        /// </param>
        /// <param name="responseSchema">
        /// The `Schema` object allows the definition of input and output data types. These types can be objects, but also primitives and arrays. Represents a select subset of an [OpenAPI 3.0 schema object](https://spec.openapis.org/oas/v3.0.3#schema).
        /// </param>
        /// <param name="responseJsonSchema">
        /// Optional. An internal detail. Use `responseJsonSchema` rather than this field.
        /// </param>
        /// <param name="presencePenalty">
        /// Optional. Presence penalty applied to the next token's logprobs if the token has already been seen in the response. This penalty is binary on/off and not dependant on the number of times the token is used (after the first). Use frequency_penalty for a penalty that increases with each use. A positive penalty will discourage the use of tokens that have already been used in the response, increasing the vocabulary. A negative penalty will encourage the use of tokens that have already been used in the response, decreasing the vocabulary.
        /// </param>
        /// <param name="frequencyPenalty">
        /// Optional. Frequency penalty applied to the next token's logprobs, multiplied by the number of times each token has been seen in the respponse so far. A positive penalty will discourage the use of tokens that have already been used, proportional to the number of times the token has been used: The more a token is used, the more difficult it is for the model to use that token again increasing the vocabulary of responses. Caution: A _negative_ penalty will encourage the model to reuse tokens proportional to the number of times the token has been used. Small negative values will reduce the vocabulary of a response. Larger negative values will cause the model to start repeating a common token until it hits the max_output_tokens limit.
        /// </param>
        /// <param name="responseLogprobs">
        /// Optional. If true, export the logprobs results in response.
        /// </param>
        /// <param name="logprobs">
        /// Optional. Only valid if response_logprobs=True. This sets the number of top logprobs, including the chosen candidate, to return at each decoding step in the Candidate.logprobs_result. The number must be in the range of [0, 20].
        /// </param>
        /// <param name="enableEnhancedCivicAnswers">
        /// Optional. Enables enhanced civic answers. It may not be available for all models.
        /// </param>
        /// <param name="responseModalities">
        /// Optional. The requested modalities of the response. Represents the set of modalities that the model can return, and should be expected in the response. This is an exact match to the modalities of the response. A model may have multiple combinations of supported modalities. If the requested modalities do not match any of the supported combinations, an error will be returned. An empty list is equivalent to requesting only text.
        /// </param>
        /// <param name="speechConfig">
        /// Config for speech generation and transcription.
        /// </param>
        /// <param name="thinkingConfig">
        /// Config for thinking features.
        /// </param>
        /// <param name="imageConfig">
        /// Config for image generation features.
        /// </param>
        /// <param name="mediaResolution">
        /// Optional. If specified, the media resolution specified will be used.
        /// </param>
        public GenerationConfig(
            int? candidateCount,
            global::System.Collections.Generic.IList<string>? stopSequences,
            int? maxOutputTokens,
            float? temperature,
            float? topP,
            int? topK,
            int? seed,
            string? responseMimeType,
            global::G.Schema? responseSchema,
            object? responseJsonSchema,
            float? presencePenalty,
            float? frequencyPenalty,
            bool? responseLogprobs,
            int? logprobs,
            bool? enableEnhancedCivicAnswers,
            global::System.Collections.Generic.IList<global::G.GenerationConfigResponseModalitie>? responseModalities,
            global::G.SpeechConfig? speechConfig,
            global::G.ThinkingConfig? thinkingConfig,
            global::G.ImageConfig? imageConfig,
            global::G.GenerationConfigMediaResolution? mediaResolution)
        {
            this.CandidateCount = candidateCount;
            this.StopSequences = stopSequences;
            this.MaxOutputTokens = maxOutputTokens;
            this.Temperature = temperature;
            this.TopP = topP;
            this.TopK = topK;
            this.Seed = seed;
            this.ResponseMimeType = responseMimeType;
            this.ResponseSchema = responseSchema;
            this.ResponseJsonSchema = responseJsonSchema;
            this.PresencePenalty = presencePenalty;
            this.FrequencyPenalty = frequencyPenalty;
            this.ResponseLogprobs = responseLogprobs;
            this.Logprobs = logprobs;
            this.EnableEnhancedCivicAnswers = enableEnhancedCivicAnswers;
            this.ResponseModalities = responseModalities;
            this.SpeechConfig = speechConfig;
            this.ThinkingConfig = thinkingConfig;
            this.ImageConfig = imageConfig;
            this.MediaResolution = mediaResolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationConfig" /> class.
        /// </summary>
        public GenerationConfig()
        {
        }
    }
}