//HintName: G.Models.IOVariable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class IOVariable
    {
        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_io_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunIOTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunIOType RunIoType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        public global::System.Collections.Generic.IList<object>? Examples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gt")]
        public int? Gt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ge")]
        public int? Ge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lt")]
        public int? Lt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("le")]
        public int? Le { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multiple_of")]
        public int? MultipleOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_inf_nan")]
        public bool? AllowInfNan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_digits")]
        public int? MaxDigits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decimal_places")]
        public int? DecimalPlaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_length")]
        public int? MinLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_length")]
        public int? MaxLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<object>? Choices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dict_schema")]
        public global::System.Collections.Generic.IList<object>? DictSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public object? Default { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optional")]
        public bool? Optional { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IOVariable" /> class.
        /// </summary>
        /// <param name="runIoType">
        /// An enumeration.
        /// </param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="examples"></param>
        /// <param name="gt"></param>
        /// <param name="ge"></param>
        /// <param name="lt"></param>
        /// <param name="le"></param>
        /// <param name="multipleOf"></param>
        /// <param name="allowInfNan"></param>
        /// <param name="maxDigits"></param>
        /// <param name="decimalPlaces"></param>
        /// <param name="minLength"></param>
        /// <param name="maxLength"></param>
        /// <param name="choices"></param>
        /// <param name="dictSchema"></param>
        /// <param name="default"></param>
        /// <param name="optional"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IOVariable(
            global::G.RunIOType runIoType,
            string? title,
            string? description,
            global::System.Collections.Generic.IList<object>? examples,
            int? gt,
            int? ge,
            int? lt,
            int? le,
            int? multipleOf,
            bool? allowInfNan,
            int? maxDigits,
            int? decimalPlaces,
            int? minLength,
            int? maxLength,
            global::System.Collections.Generic.IList<object>? choices,
            global::System.Collections.Generic.IList<object>? dictSchema,
            object? @default,
            bool? optional)
        {
            this.RunIoType = runIoType;
            this.Title = title;
            this.Description = description;
            this.Examples = examples;
            this.Gt = gt;
            this.Ge = ge;
            this.Lt = lt;
            this.Le = le;
            this.MultipleOf = multipleOf;
            this.AllowInfNan = allowInfNan;
            this.MaxDigits = maxDigits;
            this.DecimalPlaces = decimalPlaces;
            this.MinLength = minLength;
            this.MaxLength = maxLength;
            this.Choices = choices;
            this.DictSchema = dictSchema;
            this.Default = @default;
            this.Optional = optional;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IOVariable" /> class.
        /// </summary>
        public IOVariable()
        {
        }
    }
}