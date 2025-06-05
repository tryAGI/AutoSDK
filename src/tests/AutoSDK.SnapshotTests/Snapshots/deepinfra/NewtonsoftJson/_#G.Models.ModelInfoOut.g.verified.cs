//HintName: G.Models.ModelInfoOut.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelInfoOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Tags { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reported_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReportedType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("featured", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Featured { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner")]
        public bool? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Public { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("curl_inv", Required = global::Newtonsoft.Json.Required.Always)]
        public string CurlInv { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cmdline_inv", Required = global::Newtonsoft.Json.Required.Always)]
        public string CmdlineInv { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("txt_docs", Required = global::Newtonsoft.Json.Required.Always)]
        public string TxtDocs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("out_example", Required = global::Newtonsoft.Json.Required.Always)]
        public string OutExample { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("out_docs", Required = global::Newtonsoft.Json.Required.Always)]
        public string OutDocs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mask_token")]
        public string? MaskToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in_schema")]
        public object? InSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("out_schema")]
        public object? OutSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in_fields")]
        public global::System.Collections.Generic.IList<global::G.ModelFieldInfo>? InFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pricing", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.ModelPricingTime, global::G.ModelPricingUptime, global::G.ModelPricingTokens, global::G.ModelPricingInputLength, global::G.ModelPricingInputTokens, global::G.ModelPricingInputCharacterLength, global::G.ModelPricingImageUnits> Pricing { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("doc_blocks")]
        public global::System.Collections.Generic.IList<global::G.ModelDocBlock>? DocBlocks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schemas", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SchemaVariant> Schemas { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("replaced_by")]
        public string? ReplacedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deprecated")]
        public int? Deprecated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quantization")]
        public string? Quantization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mmlu")]
        public double? Mmlu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expected")]
        public string? Expected { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfoOut" /> class.
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="type"></param>
        /// <param name="tags"></param>
        /// <param name="reportedType"></param>
        /// <param name="version"></param>
        /// <param name="description"></param>
        /// <param name="featured"></param>
        /// <param name="owner">
        /// Default Value: false
        /// </param>
        /// <param name="public"></param>
        /// <param name="curlInv"></param>
        /// <param name="cmdlineInv"></param>
        /// <param name="txtDocs"></param>
        /// <param name="outExample"></param>
        /// <param name="outDocs"></param>
        /// <param name="maskToken"></param>
        /// <param name="inSchema"></param>
        /// <param name="outSchema"></param>
        /// <param name="inFields"></param>
        /// <param name="pricing"></param>
        /// <param name="docBlocks"></param>
        /// <param name="schemas"></param>
        /// <param name="meta"></param>
        /// <param name="maxTokens"></param>
        /// <param name="replacedBy"></param>
        /// <param name="deprecated"></param>
        /// <param name="quantization"></param>
        /// <param name="mmlu"></param>
        /// <param name="expected"></param>
        public ModelInfoOut(
            string modelName,
            string type,
            global::System.Collections.Generic.IList<string> tags,
            string reportedType,
            string version,
            bool featured,
            bool @public,
            string curlInv,
            string cmdlineInv,
            string txtDocs,
            string outExample,
            string outDocs,
            global::G.AnyOf<global::G.ModelPricingTime, global::G.ModelPricingUptime, global::G.ModelPricingTokens, global::G.ModelPricingInputLength, global::G.ModelPricingInputTokens, global::G.ModelPricingInputCharacterLength, global::G.ModelPricingImageUnits> pricing,
            global::System.Collections.Generic.IList<global::G.SchemaVariant> schemas,
            string? description,
            bool? owner,
            string? maskToken,
            object? inSchema,
            object? outSchema,
            global::System.Collections.Generic.IList<global::G.ModelFieldInfo>? inFields,
            global::System.Collections.Generic.IList<global::G.ModelDocBlock>? docBlocks,
            object? meta,
            int? maxTokens,
            string? replacedBy,
            int? deprecated,
            string? quantization,
            double? mmlu,
            string? expected)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.ReportedType = reportedType ?? throw new global::System.ArgumentNullException(nameof(reportedType));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Featured = featured;
            this.Public = @public;
            this.CurlInv = curlInv ?? throw new global::System.ArgumentNullException(nameof(curlInv));
            this.CmdlineInv = cmdlineInv ?? throw new global::System.ArgumentNullException(nameof(cmdlineInv));
            this.TxtDocs = txtDocs ?? throw new global::System.ArgumentNullException(nameof(txtDocs));
            this.OutExample = outExample ?? throw new global::System.ArgumentNullException(nameof(outExample));
            this.OutDocs = outDocs ?? throw new global::System.ArgumentNullException(nameof(outDocs));
            this.Pricing = pricing;
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
            this.Description = description;
            this.Owner = owner;
            this.MaskToken = maskToken;
            this.InSchema = inSchema;
            this.OutSchema = outSchema;
            this.InFields = inFields;
            this.DocBlocks = docBlocks;
            this.Meta = meta;
            this.MaxTokens = maxTokens;
            this.ReplacedBy = replacedBy;
            this.Deprecated = deprecated;
            this.Quantization = quantization;
            this.Mmlu = mmlu;
            this.Expected = expected;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfoOut" /> class.
        /// </summary>
        public ModelInfoOut()
        {
        }
    }
}