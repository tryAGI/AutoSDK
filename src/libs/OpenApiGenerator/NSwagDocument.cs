using Newtonsoft.Json;
using NJsonSchema.CodeGeneration.CSharp;

#nullable disable

#pragma warning disable

namespace H.Generators;

public class FromDocument
{
    [JsonProperty("json")]
    public string Json { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("output")]
    public object Output { get; set; }

    [JsonProperty("newLineBehavior")]
    public string NewLineBehavior { get; set; }
}

public class DocumentGenerator
{
    [JsonProperty("fromDocument")]
    public FromDocument FromDocument { get; set; }
}

public class OpenApiToCSharpClient
{
    [JsonProperty("clientBaseClass")]
    public string ClientBaseClass { get; set; }

    [JsonProperty("configurationClass")]
    public string ConfigurationClass { get; set; }

    [JsonProperty("generateClientClasses")]
    public bool GenerateClientClasses { get; set; }

    [JsonProperty("generateClientInterfaces")]
    public bool GenerateClientInterfaces { get; set; }

    [JsonProperty("clientBaseInterface")]
    public string ClientBaseInterface { get; set; }

    [JsonProperty("injectHttpClient")]
    public bool InjectHttpClient { get; set; }

    [JsonProperty("disposeHttpClient")]
    public bool DisposeHttpClient { get; set; }

    [JsonProperty("protectedMethods")]
    public string[] ProtectedMethods { get; set; }

    [JsonProperty("generateExceptionClasses")]
    public bool GenerateExceptionClasses { get; set; }

    [JsonProperty("exceptionClass")]
    public string ExceptionClass { get; set; }

    [JsonProperty("wrapDtoExceptions")]
    public bool WrapDtoExceptions { get; set; }

    [JsonProperty("useHttpClientCreationMethod")]
    public bool UseHttpClientCreationMethod { get; set; }

    [JsonProperty("httpClientType")]
    public string HttpClientType { get; set; }

    [JsonProperty("useHttpRequestMessageCreationMethod")]
    public bool UseHttpRequestMessageCreationMethod { get; set; }

    [JsonProperty("useBaseUrl")]
    public bool UseBaseUrl { get; set; }

    [JsonProperty("generateBaseUrlProperty")]
    public bool GenerateBaseUrlProperty { get; set; }

    [JsonProperty("generateSyncMethods")]
    public bool GenerateSyncMethods { get; set; }

    [JsonProperty("generatePrepareRequestAndProcessResponseAsAsyncMethods")]
    public bool GeneratePrepareRequestAndProcessResponseAsAsyncMethods { get; set; }

    [JsonProperty("exposeJsonSerializerSettings")]
    public bool ExposeJsonSerializerSettings { get; set; }

    [JsonProperty("clientClassAccessModifier")]
    public string ClientClassAccessModifier { get; set; }

    [JsonProperty("typeAccessModifier")]
    public string TypeAccessModifier { get; set; }
    
    [JsonProperty("propertySetterAccessModifier")]
    public string PropertySetterAccessModifier { get; set; }

    [JsonProperty("generateContractsOutput")]
    public bool GenerateContractsOutput { get; set; }

    [JsonProperty("contractsNamespace")]
    public object ContractsNamespace { get; set; }

    [JsonProperty("contractsOutputFilePath")]
    public object ContractsOutputFilePath { get; set; }

    [JsonProperty("parameterDateTimeFormat")]
    public string ParameterDateTimeFormat { get; set; }

    [JsonProperty("parameterDateFormat")]
    public string ParameterDateFormat { get; set; }

    [JsonProperty("generateUpdateJsonSerializerSettingsMethod")]
    public bool GenerateUpdateJsonSerializerSettingsMethod { get; set; }

    [JsonProperty("useRequestAndResponseSerializationSettings")]
    public bool UseRequestAndResponseSerializationSettings { get; set; }

    [JsonProperty("serializeTypeInformation")]
    public bool SerializeTypeInformation { get; set; }

    [JsonProperty("queryNullValue")]
    public string QueryNullValue { get; set; }

    [JsonProperty("className")]
    public string ClassName { get; set; }

    [JsonProperty("operationGenerationMode")]
    public string OperationGenerationMode { get; set; }

    [JsonProperty("additionalNamespaceUsages")]
    public string[] AdditionalNamespaceUsages { get; set; }

    [JsonProperty("additionalContractNamespaceUsages")]
    public string[] AdditionalContractNamespaceUsages { get; set; }

    [JsonProperty("checksumCacheEnabled")]
    public bool ChecksumCacheEnabled { get; set; }

    [JsonProperty("generateOptionalParameters")]
    public bool GenerateOptionalParameters { get; set; }

    [JsonProperty("generateJsonMethods")]
    public bool GenerateJsonMethods { get; set; }

    [JsonProperty("enforceFlagEnums")]
    public bool EnforceFlagEnums { get; set; }

    [JsonProperty("parameterArrayType")]
    public string ParameterArrayType { get; set; }

    [JsonProperty("parameterDictionaryType")]
    public string ParameterDictionaryType { get; set; }

    [JsonProperty("responseArrayType")]
    public string ResponseArrayType { get; set; }

    [JsonProperty("responseDictionaryType")]
    public string ResponseDictionaryType { get; set; }

    [JsonProperty("wrapResponses")]
    public bool WrapResponses { get; set; }

    [JsonProperty("wrapResponseMethods")]
    public string[] WrapResponseMethods { get; set; }

    [JsonProperty("generateResponseClasses")]
    public bool GenerateResponseClasses { get; set; }

    [JsonProperty("responseClass")]
    public string ResponseClass { get; set; }

    [JsonProperty("namespace")]
    public string Namespace { get; set; }

    [JsonProperty("requiredPropertiesMustBeDefined")]
    public bool RequiredPropertiesMustBeDefined { get; set; }

    [JsonProperty("dateType")]
    public string DateType { get; set; }

    [JsonProperty("jsonConverters")]
    public string[] JsonConverters { get; set; }

    [JsonProperty("anyType")]
    public string AnyType { get; set; }

    [JsonProperty("dateTimeType")]
    public string DateTimeType { get; set; }

    [JsonProperty("timeType")]
    public string TimeType { get; set; }

    [JsonProperty("timeSpanType")]
    public string TimeSpanType { get; set; }

    [JsonProperty("arrayType")]
    public string ArrayType { get; set; }

    [JsonProperty("arrayInstanceType")]
    public string ArrayInstanceType { get; set; }

    [JsonProperty("dictionaryType")]
    public string DictionaryType { get; set; }

    [JsonProperty("dictionaryInstanceType")]
    public string DictionaryInstanceType { get; set; }

    [JsonProperty("arrayBaseType")]
    public string ArrayBaseType { get; set; }

    [JsonProperty("dictionaryBaseType")]
    public string DictionaryBaseType { get; set; }

    [JsonProperty("classStyle")]
    public CSharpClassStyle ClassStyle { get; set; }

    [JsonProperty("jsonLibrary")]
    public string JsonLibrary { get; set; }

    [JsonProperty("generateDefaultValues")]
    public bool GenerateDefaultValues { get; set; }

    [JsonProperty("generateDataAnnotations")]
    public bool GenerateDataAnnotations { get; set; }

    [JsonProperty("excludedTypeNames")]
    public string[] ExcludedTypeNames { get; set; }

    [JsonProperty("excludedParameterNames")]
    public string[] ExcludedParameterNames { get; set; }

    [JsonProperty("handleReferences")]
    public bool HandleReferences { get; set; }

    [JsonProperty("generateImmutableArrayProperties")]
    public bool GenerateImmutableArrayProperties { get; set; }

    [JsonProperty("generateImmutableDictionaryProperties")]
    public bool GenerateImmutableDictionaryProperties { get; set; }

    [JsonProperty("jsonSerializerSettingsTransformationMethod")]
    public object JsonSerializerSettingsTransformationMethod { get; set; }

    [JsonProperty("inlineNamedArrays")]
    public bool InlineNamedArrays { get; set; }

    [JsonProperty("inlineNamedDictionaries")]
    public bool InlineNamedDictionaries { get; set; }

    [JsonProperty("inlineNamedTuples")]
    public bool InlineNamedTuples { get; set; }

    [JsonProperty("inlineNamedAny")]
    public bool InlineNamedAny { get; set; }

    [JsonProperty("generateDtoTypes")]
    public bool GenerateDtoTypes { get; set; }

    [JsonProperty("generateOptionalPropertiesAsNullable")]
    public bool GenerateOptionalPropertiesAsNullable { get; set; }

    [JsonProperty("generateNullableReferenceTypes")]
    public bool GenerateNullableReferenceTypes { get; set; }

    [JsonProperty("generateNativeRecords")]
    public bool GenerateNativeRecords { get; set; }

    [JsonProperty("templateDirectory")]
    public string TemplateDirectory { get; set; }

    [JsonProperty("typeNameGeneratorType")]
    public object TypeNameGeneratorType { get; set; }

    [JsonProperty("propertyNameGeneratorType")]
    public object PropertyNameGeneratorType { get; set; }

    [JsonProperty("enumNameGeneratorType")]
    public object EnumNameGeneratorType { get; set; }

    [JsonProperty("serviceHost")]
    public object ServiceHost { get; set; }

    [JsonProperty("serviceSchemes")]
    public object ServiceSchemes { get; set; }

    [JsonProperty("output")]
    public string Output { get; set; }

    [JsonProperty("newLineBehavior")]
    public string NewLineBehavior { get; set; }
}

public class CodeGenerators
{
    [JsonProperty("openApiToCSharpClient")]
    public OpenApiToCSharpClient OpenApiToCSharpClient { get; set; }
}

public class NSwagDocument
{
    [JsonProperty("runtime")]
    public string Runtime { get; set; }

    [JsonProperty("defaultVariables")]
    public object DefaultVariables { get; set; }

    [JsonProperty("documentGenerator")]
    public DocumentGenerator DocumentGenerator { get; set; }

    [JsonProperty("codeGenerators")]
    public CodeGenerators CodeGenerators { get; set; }
}
