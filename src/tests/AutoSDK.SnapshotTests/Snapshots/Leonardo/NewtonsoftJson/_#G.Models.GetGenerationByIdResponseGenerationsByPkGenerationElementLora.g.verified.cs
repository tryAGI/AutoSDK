//HintName: G.Models.GetGenerationByIdResponseGenerationsByPkGenerationElementLora.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Element used for the generation.
    /// </summary>
    public sealed partial class GetGenerationByIdResponseGenerationsByPkGenerationElementLora
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("akUUID")]
        public global::G.Lora? AkUUID { get; set; }

        /// <summary>
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("baseModel")]
        public global::G.SdVersions? BaseModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public global::G.Lora? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public global::G.Lora? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("urlImage")]
        public global::G.Lora? UrlImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weightDefault")]
        public global::G.Lora? WeightDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weightMax")]
        public global::G.Lora? WeightMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weightMin")]
        public global::G.Lora? WeightMin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationByIdResponseGenerationsByPkGenerationElementLora" /> class.
        /// </summary>
        /// <param name="akUUID"></param>
        /// <param name="baseModel">
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </param>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="urlImage"></param>
        /// <param name="weightDefault"></param>
        /// <param name="weightMax"></param>
        /// <param name="weightMin"></param>
        public GetGenerationByIdResponseGenerationsByPkGenerationElementLora(
            global::G.Lora? akUUID,
            global::G.SdVersions? baseModel,
            global::G.Lora? description,
            global::G.Lora? name,
            global::G.Lora? urlImage,
            global::G.Lora? weightDefault,
            global::G.Lora? weightMax,
            global::G.Lora? weightMin)
        {
            this.AkUUID = akUUID;
            this.BaseModel = baseModel;
            this.Description = description;
            this.Name = name;
            this.UrlImage = urlImage;
            this.WeightDefault = weightDefault;
            this.WeightMax = weightMax;
            this.WeightMin = weightMin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationByIdResponseGenerationsByPkGenerationElementLora" /> class.
        /// </summary>
        public GetGenerationByIdResponseGenerationsByPkGenerationElementLora()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.GetGenerationByIdResponseGenerationsByPkGenerationElementLora? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetGenerationByIdResponseGenerationsByPkGenerationElementLora>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.GetGenerationByIdResponseGenerationsByPkGenerationElementLora?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.GetGenerationByIdResponseGenerationsByPkGenerationElementLora?>(serializer.Deserialize<global::G.GetGenerationByIdResponseGenerationsByPkGenerationElementLora>(jsonReader));
        }

    }
}