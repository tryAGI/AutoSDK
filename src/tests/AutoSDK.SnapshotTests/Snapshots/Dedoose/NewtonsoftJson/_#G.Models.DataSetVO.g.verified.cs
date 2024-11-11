//HintName: G.Models.DataSetVO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataSetVO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectIdKey")]
        public string? ProjectIdKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdById")]
        public global::System.Guid? CreatedById { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createStamp")]
        public global::System.DateTime? CreateStamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("desciption")]
        public string? Desciption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objectIdLists")]
        public global::G.DataSetObjectIds? ObjectIdLists { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("areExcerptsFiltered")]
        public bool? AreExcerptsFiltered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("areResourcesFiltered")]
        public bool? AreResourcesFiltered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("areTagsFiltered")]
        public bool? AreTagsFiltered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("areUsersFiltered")]
        public bool? AreUsersFiltered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("areDescriptorsFiltered")]
        public bool? AreDescriptorsFiltered { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetVO" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="projectIdKey">
        /// Included only in responses
        /// </param>
        /// <param name="createdById"></param>
        /// <param name="createStamp"></param>
        /// <param name="title"></param>
        /// <param name="desciption"></param>
        /// <param name="objectIdLists"></param>
        /// <param name="areExcerptsFiltered"></param>
        /// <param name="areResourcesFiltered"></param>
        /// <param name="areTagsFiltered"></param>
        /// <param name="areUsersFiltered"></param>
        /// <param name="areDescriptorsFiltered"></param>
        public DataSetVO(
            global::System.Guid? id,
            global::System.Guid? projectId,
            string? projectIdKey,
            global::System.Guid? createdById,
            global::System.DateTime? createStamp,
            string? title,
            string? desciption,
            global::G.DataSetObjectIds? objectIdLists,
            bool? areExcerptsFiltered,
            bool? areResourcesFiltered,
            bool? areTagsFiltered,
            bool? areUsersFiltered,
            bool? areDescriptorsFiltered)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.ProjectIdKey = projectIdKey;
            this.CreatedById = createdById;
            this.CreateStamp = createStamp;
            this.Title = title;
            this.Desciption = desciption;
            this.ObjectIdLists = objectIdLists;
            this.AreExcerptsFiltered = areExcerptsFiltered;
            this.AreResourcesFiltered = areResourcesFiltered;
            this.AreTagsFiltered = areTagsFiltered;
            this.AreUsersFiltered = areUsersFiltered;
            this.AreDescriptorsFiltered = areDescriptorsFiltered;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetVO" /> class.
        /// </summary>
        public DataSetVO()
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
        public static global::G.DataSetVO? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DataSetVO>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.DataSetVO?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.DataSetVO?>(serializer.Deserialize<global::G.DataSetVO>(jsonReader));
        }

    }
}