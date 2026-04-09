//HintName: G.Models.Bm25Config.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration of the local bm25 models.
    /// </summary>
    public sealed partial class Bm25Config
    {
        /// <summary>
        /// Controls term frequency saturation. Higher values mean term frequency has more impact. Default is 1.2<br/>
        /// Default Value: 1.2F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("k")]
        public double? K { get; set; }

        /// <summary>
        /// Controls document length normalization. Ranges from 0 (no normalization) to 1 (full normalization). Higher values mean longer documents have less impact. Default is 0.75.<br/>
        /// Default Value: 0.75F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("b")]
        public double? B { get; set; }

        /// <summary>
        /// Expected average document length in the collection. Default is 256.<br/>
        /// Default Value: 256
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg_len")]
        public double? AvgLen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokenizer")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TokenizerTypeJsonConverter))]
        public global::G.TokenizerType? Tokenizer { get; set; }

        /// <summary>
        /// Defines which language to use for text preprocessing. This parameter is used to construct default stopwords filter and stemmer. To disable language-specific processing, set this to `"language": "none"`. If not specified, English is assumed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Lowercase the text before tokenization. Default is `true`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lowercase")]
        public bool? Lowercase { get; set; }

        /// <summary>
        /// If true, normalize tokens by folding accented characters to ASCII (e.g., "ação" -&gt; "acao"). Default is `false`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ascii_folding")]
        public bool? AsciiFolding { get; set; }

        /// <summary>
        /// Configuration of the stopwords filter. Supports list of pre-defined languages and custom stopwords. Default: initialized for specified `language` or English if not specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stopwords")]
        public global::G.StopwordsInterface? Stopwords { get; set; }

        /// <summary>
        /// Configuration of the stemmer. Processes tokens to their root form. Default: initialized Snowball stemmer for specified `language` or English if not specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stemmer")]
        public global::G.StemmingAlgorithm? Stemmer { get; set; }

        /// <summary>
        /// Minimum token length to keep. If token is shorter than this, it will be discarded. Default is `None`, which means no minimum length.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_token_len")]
        public int? MinTokenLen { get; set; }

        /// <summary>
        /// Maximum token length to keep. If token is longer than this, it will be discarded. Default is `None`, which means no maximum length.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_token_len")]
        public int? MaxTokenLen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Bm25Config" /> class.
        /// </summary>
        /// <param name="k">
        /// Controls term frequency saturation. Higher values mean term frequency has more impact. Default is 1.2<br/>
        /// Default Value: 1.2F
        /// </param>
        /// <param name="b">
        /// Controls document length normalization. Ranges from 0 (no normalization) to 1 (full normalization). Higher values mean longer documents have less impact. Default is 0.75.<br/>
        /// Default Value: 0.75F
        /// </param>
        /// <param name="avgLen">
        /// Expected average document length in the collection. Default is 256.<br/>
        /// Default Value: 256
        /// </param>
        /// <param name="tokenizer"></param>
        /// <param name="language">
        /// Defines which language to use for text preprocessing. This parameter is used to construct default stopwords filter and stemmer. To disable language-specific processing, set this to `"language": "none"`. If not specified, English is assumed.
        /// </param>
        /// <param name="lowercase">
        /// Lowercase the text before tokenization. Default is `true`.
        /// </param>
        /// <param name="asciiFolding">
        /// If true, normalize tokens by folding accented characters to ASCII (e.g., "ação" -&gt; "acao"). Default is `false`.
        /// </param>
        /// <param name="stopwords">
        /// Configuration of the stopwords filter. Supports list of pre-defined languages and custom stopwords. Default: initialized for specified `language` or English if not specified.
        /// </param>
        /// <param name="stemmer">
        /// Configuration of the stemmer. Processes tokens to their root form. Default: initialized Snowball stemmer for specified `language` or English if not specified.
        /// </param>
        /// <param name="minTokenLen">
        /// Minimum token length to keep. If token is shorter than this, it will be discarded. Default is `None`, which means no minimum length.
        /// </param>
        /// <param name="maxTokenLen">
        /// Maximum token length to keep. If token is longer than this, it will be discarded. Default is `None`, which means no maximum length.
        /// </param>
        public Bm25Config(
            double? k,
            double? b,
            double? avgLen,
            global::G.TokenizerType? tokenizer,
            string? language,
            bool? lowercase,
            bool? asciiFolding,
            global::G.StopwordsInterface? stopwords,
            global::G.StemmingAlgorithm? stemmer,
            int? minTokenLen,
            int? maxTokenLen)
        {
            this.K = k;
            this.B = b;
            this.AvgLen = avgLen;
            this.Tokenizer = tokenizer;
            this.Language = language;
            this.Lowercase = lowercase;
            this.AsciiFolding = asciiFolding;
            this.Stopwords = stopwords;
            this.Stemmer = stemmer;
            this.MinTokenLen = minTokenLen;
            this.MaxTokenLen = maxTokenLen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bm25Config" /> class.
        /// </summary>
        public Bm25Config()
        {
        }
    }
}